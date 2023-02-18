using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace ModsToolsClipboard
{

    public partial class MainForm : Form
    {
        static public List<string> steampath = new List<string>();
        static public RegistryKey hostkey = Registry.CurrentUser;
        static public bool is_ignore_error = false;

        Dictionary<string, string> langs = new Dictionary<string, string>();
        public static Dictionary<string, string> currentlang  = new Dictionary<string, string>();
        string currentlangName = "English";
        string currentlangFileName = "";
        static string filesettings = "./settings.ini";
        static string filesettingssteampaths = "./steampaths.txt";
        static string filelocalizationdir = "Localization";

        string NoticeErrReestr = "* Информация в реестре о Steam не найдена. Это повлияет только на определение игры, но не папки мода.";
        string NoticeErrSteam = "* Не найдена информация о Steam. Попробуйте запустить программу от имени администратора, чтобы программа проверила другие разделы steam\n";
        string NoticeErrSteamPath = "* Не найден путь к Steam...\n";
        string NoticeHelp = "В данную область можно вставлять одну/несколько ссылок, id модов.\nИспользуйте в качестве разделителей: новую строку, пробел, \";\".";
        string NoticeHelpTitle = "Справка";

        public MainForm() {
            InitializeComponent();
            DoubleBuffered = true;
            Directory.CreateDirectory(filelocalizationdir);
            LoadSettings();
            if (File.Exists(filesettingssteampaths)) steampath.AddRange(File.ReadAllLines(filesettingssteampaths));
            if (steampath.Count < 1) {
                steampath.Clear();
                foreach (RegistryKey hk in new RegistryKey[] { Registry.CurrentUser, Registry.LocalMachine }) {
                    string tpath = Registry.GetValue(hostkey + "\\SOFTWARE\\Valve\\Steam", "SteamPath", "err").ToString();
                    if (tpath != "err") {
                        steampath.Add(tpath); //Добавляем основной путь
                        hostkey = hk;
                        break;
                    } else {
                        if (hk == Registry.LocalMachine) {
                            WindowsIdentity CurrentIdentity = WindowsIdentity.GetCurrent();
                            WindowsPrincipal CurrentPrincipal = new WindowsPrincipal(CurrentIdentity);
                            if (CurrentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)) {
                                tpath = Registry.GetValue(Registry.LocalMachine + "\\SOFTWARE\\Valve\\Steam", "SteamPath", "err").ToString();
                                if (tpath != "err") {
                                    steampath.Add(tpath); //Добавляем основной путь
                                    hostkey = hk;
                                    break;
                                } else label_err.Text += NoticeErrReestr;
                            } else label_err.Text += NoticeErrSteam;
                        }
                    }
                }
                //получаем доп путь к стим
                string libfile;
                if (steampath.Count > 0 && File.Exists(libfile = steampath[0] + "/steamapps/libraryfolders.vdf")) {
                    string libfolders = File.ReadAllText(libfile);
                    int startsubstr = libfolders.IndexOf("\"path\"\t\t\"") + 9;
                    foreach (int index in IndexOfMore(libfolders, "\"path\"\t\t\"")) {
                        steampath.Add(libfolders.Substring(index + 9, libfolders.IndexOf('"', index + 9) - 9 - index).Replace(@"\\", "/"));
                    }

                }
            }
            //Проверяем ошибки
            if (steampath.Count < 1)
                label_err.Text += NoticeErrSteamPath;

            if (label_err.Text.Length > 0)
                panel4.Visible = true;

            string[] langfiles = Directory.GetFiles(filelocalizationdir, "*.xml");
            foreach (string langfile in langfiles) {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(langfile);
                XmlElement xRoot = xDoc.DocumentElement;
                if (xRoot != null) {
                    langs.Add(xRoot.GetAttribute("name"), xRoot.GetAttribute("filename"));
                    languageContextMenuStrip.Items.Add(xRoot.GetAttribute("name"));
                    if (currentlangName == xRoot.GetAttribute("name"))
                        currentlangFileName = xRoot.GetAttribute("filename");
                }
            }
            currentlang = languageLoad(currentlangName);
            foreach (ToolStripItem item in languageContextMenuStrip.Items)
                item.Click += LangSelect;


        }

        private void LangSelect(object sender, EventArgs e) {
            ToolStripItem me = (ToolStripItem)sender;
            currentlangName = me.Text;
            //Application.Restart();
            currentlang = languageLoad(currentlangName);
        }

        private void LoadSettings() {
            try {
                if (File.Exists(filesettings)) {
                    INIManager FS = new INIManager(filesettings);
                    string lang = FS.GetPrivateString("Main", "Language");
                    if (lang.Length > 1) {
                        if (lang != "Default")
                            currentlangName = lang;
                        checkBoxAnalysis.Checked = Convert.ToBoolean(FS.GetPrivateString("Main", "AnalysisClipboard"));
                        checkBoxMoreInf.Checked = Convert.ToBoolean(FS.GetPrivateString("Main", "MoreInf"));
                        checkBoxIgnoreErr.Checked = is_ignore_error = Convert.ToBoolean(FS.GetPrivateString("Main", "IgnoreErr"));
                        checkBoxSaveWindowSize.Checked = Convert.ToBoolean(FS.GetPrivateString("Main", "SaveWindowSize"));
                        if (checkBoxSaveWindowSize.Checked)
                            Size = new System.Drawing.Size(Convert.ToInt32(FS.GetPrivateString("Main", "WindowSizeWidth")), Convert.ToInt32(FS.GetPrivateString("Main", "WindowSizeHeight")));
                    }
                }
            } catch (Exception) { }

        }

        private void SaveSettings() {
            if (!File.Exists(filesettings)) File.Create(filesettings).Close();
            INIManager FS = new INIManager(filesettings);
            FS.WritePrivateString("Main", "AnalysisClipboard", checkBoxAnalysis.Checked.ToString());
            FS.WritePrivateString("Main", "MoreInf", checkBoxMoreInf.Checked.ToString());
            FS.WritePrivateString("Main", "IgnoreErr", is_ignore_error.ToString());
            FS.WritePrivateString("Main", "SaveWindowSize", checkBoxSaveWindowSize.Checked.ToString());
            FS.WritePrivateString("Main", "Language", currentlangName);
            if (checkBoxSaveWindowSize.Checked) {
                FS.WritePrivateString("Main", "WindowSizeWidth", Size.Width.ToString());
                FS.WritePrivateString("Main", "WindowSizeHeight", Size.Height.ToString());
            }
        }

        public int[] IndexOfMore(string source, string substring) {
            var indices = new List<int>();

            int index = source.IndexOf(substring, 0);
            while (index > -1) {
                indices.Add(index);
                index = source.IndexOf(substring, index + substring.Length);
            }
            return indices.ToArray();
        }

        private void button1_Click(object sender, EventArgs e) {
            string text = textBox1.Text.Trim().Replace("\r", "").Trim('&');
            if (text.Length < 3) return;
            
            
            char sep = '\0';
            //Определим тип входных данных
            if (text.Split(' ').Length > 1)
                sep = ' ';
            if (text.Split(';').Length > 1)
                sep = ';';
            if (text.Split('\n').Length > 1)
                sep = '\n';
             
            // Если содержимое - это HTML приколы
            if (Regex.IsMatch(text, "(<.*a)[\\s\\S](href=\").*(\">)")) {
                List<string> links = new List<string>();
                string temptext = text;
                Match texthtml = Regex.Match(text, "(<.*a)[\\s\\S](href=\")");
                while (texthtml.Success) {
                    string textlink_andsep = text.Substring(texthtml.Index + texthtml.Length);
                    Match link = Regex.Match(textlink_andsep, "(\"[^>]*>)");

                    string added = textlink_andsep.Substring(0, link.Index);
                    int sremove = texthtml.Length + added.Length + link.Length;
                    links.Add(added);
                    temptext = temptext.Remove(texthtml.Index, sremove);
                    temptext = temptext.Insert(texthtml.Index, string.Concat(Enumerable.Repeat("\0", sremove)));
                    texthtml = texthtml.NextMatch();
                }
                string sepjoin;
                if (links.Count > 1) {
                    sepjoin = sep != '\0' ? sep.ToString() : (sep = '\n').ToString();
                    textBox1.Text = text = string.Join(sepjoin, links.Distinct().ToArray());
                } else {
                    textBox1.Text = text = links[0];
                }
            }

            if (sep == '\0' && (text.ToLower().IndexOf("steamcommunity.com") >= 0 || text.ToLower().IndexOf("store.steampowered.com") >= 0)) {
                var a = new ModInfo(text, checkBoxMoreInf.Checked);
                a.Show();
            } else {
                foreach (string link in text.Split(sep)) {
                    if (link.Length < 3 | !(link.ToLower().IndexOf("steamcommunity.com") >= 0 || link.ToLower().IndexOf("store.steampowered.com") >= 0)) continue;
                    var a = new ModInfo(link, checkBoxMoreInf.Checked);
                    if (!a.IsDisposed) a.Show();
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e) {
            Height = pictureBox1.Height * BoolToInt(pictureBox1.Visible)
                   + panel1.Height * BoolToInt(panel1.Visible)
                   + panel2.Height * BoolToInt(panel2.Visible)
                   + panel3.Height * BoolToInt(panel3.Visible)
                   + panel4.Height * BoolToInt(panel4.Visible)
                   + panel5.Height * BoolToInt(panel5.Visible)
                   + panel7.Height * BoolToInt(panel7.Visible)
                   + 34 + 8; //Рамка и прочее
        }

        private int BoolToInt(bool a) {
            return a ? 1 : 0;
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox1.Text = Clipboard.GetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            timer_a.Enabled = checkBoxAnalysis.Checked;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            is_ignore_error = checkBoxIgnoreErr.Checked;
        }

        private void button1_LinkClicked(object sender, EventArgs e) {
             panel5.Visible = true;
            listBox1.Items.Clear();
            foreach (string item in steampath)
                listBox1.Items.Add(item);
            Form1_Shown(sender, e);
            buttonDirsSteam.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e) {
            panel5.Visible = false;
            buttonDirsSteam.Enabled = true;
            steampath.Clear();
            foreach (var item in listBox1.Items)
                steampath.Add(item.ToString());
            Form1_Shown(sender, e);
        }

        private void button3_Click(object sender, EventArgs e) {
            panel5.Visible = true;
            Form1_Shown(sender, e);
        }

        static string delaycb = null;
        private void timer_a_Tick(object sender, EventArgs e) {
            string cb = Clipboard.GetText().Trim().Trim('&');
            if (cb == delaycb) return;
            if (cb.ToLower().IndexOf("steamcommunity.com") > -1 || cb.ToLower().IndexOf("store.steampowered.com") > -1) {
                textBox1.Text = cb;
                delaycb = cb;
                button1_Click(sender, e);
            }
            timer_a.Enabled = checkBoxAnalysis.Checked;


        }
        ToolTip h = new ToolTip();
        private void button_help_MouseHover(object sender, EventArgs e) {
            h.Show(NoticeHelpTitle, button_help);
        }

        private void button_help_Click(object sender, EventArgs e) {
            MessageBox.Show(NoticeHelp, NoticeHelpTitle);
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized)
                this.ShowInTaskbar = false;
            else
                this.ShowInTaskbar = true;
        }

        private void button5_Click(object sender, EventArgs e) {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private int sortingAB(int a, int b) {
            return b.CompareTo(a);
        }

        private void button4_Click(object sender, EventArgs e) {
            string t = textBox2.Text;
            if (Directory.Exists(t))
                listBox1.Items.Add(t);
        }

        private void button7_Click(object sender, EventArgs e) {
            panel5.Visible = false;
            buttonDirsSteam.Enabled = true;
            Form1_Shown(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            File.WriteAllLines(filesettingssteampaths, steampath.ToArray());
            SaveSettings();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProgInf a = new ProgInf();
            a.ShowDialog();
        }

        private void buttonLang_Click(object sender, EventArgs e) {
            int x = Cursor.Position.X - Location.X ;
            int y = Cursor.Position.Y - Location.Y - 34;
            languageContextMenuStrip.Show(this, x,y);
        }

        public Dictionary<string, string> languageLoad(string lang) {
            Dictionary<string, string> currentlang = new Dictionary<string, string>();
            string langfile;
            if (langs.ContainsKey(lang))
                langfile = $"{ filelocalizationdir}/{ langs[lang]}";
            else return currentlang;
            
            if (!string.IsNullOrEmpty(langfile) && File.Exists(langfile)) {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(langfile);
                XmlElement xRoot = xDoc.DocumentElement;
                if (xRoot != null)
                    foreach (XmlElement xnode in xRoot) currentlang.Add(xnode.GetAttribute("id"), xnode.GetAttribute("text"));
            }
            if (lang.ToLower() == "default")
                Application.Restart();
            languageUse(currentlang, this);

            languageGet(currentlang, "NoticeErrReestr", ref NoticeErrReestr);
            languageGet(currentlang, "NoticeErrSteam", ref NoticeErrSteam);
            languageGet(currentlang, "NoticeErrSteamPath", ref NoticeErrSteamPath);
            languageGet(currentlang, "NoticeHelp", ref NoticeHelp);
            languageGet(currentlang, "NoticeHelpTitle", ref NoticeHelpTitle);

            languageGet(currentlang, "NoticeNotInstall", ref ModInfo.NoticeNotInstall);
            languageGet(currentlang, "NoticeGameErr", ref ModInfo.NoticeGameErr);
            languageGet(currentlang, "NoticeLinkErr", ref ModInfo.NoticeLinkErr);
            languageGet(currentlang, "NoticeClipboard", ref ModInfo.NoticeClipboard);

            return currentlang;
        }

        public static void languageUse(Dictionary<string, string> currentlang, Control control) {
            control.Text = languageGet(currentlang, control.Name, control.Text);
            foreach (Control ctr in control.Controls) {
                if (ctr.Controls.Count > 0) languageUse(currentlang, ctr);
                ctr.Text = languageGet(currentlang, ctr.Name, ctr.Text);
            }
        }

        public static void languageGet(Dictionary<string, string> currentlang, string key, ref string outputtext) {
                if (currentlang.ContainsKey(key))
                    outputtext = currentlang[key].Replace("\\n","\n");
        }

        public static string languageGet(Dictionary<string, string> currentlang, string key, string outputtext) {
            if (currentlang.ContainsKey(key))
                return currentlang[key].Replace("\\n", "\n");
            else return outputtext;
        }


    }
}
