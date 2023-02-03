using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ModsToolsClipboard
{
    public partial class ModInfo : Form
    {
        string link;

        public static string NoticeNotInstall = "Not installed.";
        public static string NoticeGameErr = "The game is not defined.";
        public static string NoticeLinkErr = "The link is not recognized..";
        public static string NoticeClipboard = "Copied to Clipboard..";
        public ModInfo(string _link, bool moreinfo = false) {
            InitializeComponent();
            MainForm.languageUse(MainForm.currentlang, this);
            bool Is_Mode;
            string modid = "";
            string gameid = "";
            link = _link + (IsNumberString(_link) ? "":"&");
            // Определяем, мод это или игра
            groupBox1.Visible = moreinfo;
            if (link.IndexOf("?id=") > -1) {
                modid = link.Substring(link.IndexOf("?id=") + 4, link.IndexOf("&") - link.IndexOf("?id=") - 4);
                Is_Mode = true;
            } else if (link.IndexOf("/app/") > -1) {
                gameid = link.Substring(link.IndexOf("/app/") + 5, link.IndexOf("&") - link.IndexOf("/app/") - 5).Split('/')[0];
                Is_Mode = false;
            } else if (Regex.IsMatch(link, @"^\d+$")) { //Если ID
                modid = link;
                Is_Mode = true;
            } else {
                modid = null;
                gameid = null;
                Is_Mode = false;
            }
            linkLabelLinkMod.Text = link;
            Thread task = new Thread(new ThreadStart(() => { GetModInfo(modid, gameid, Is_Mode); }));
            task.Start();
        }
        static bool IsNumberString(string input) {
            foreach (char c in input)
                if (!Char.IsNumber(c))
                    return false;
            return true;
        }

        void GetModInfo(string modid, string gameid, bool Is_Mode) {
            string GameName = "";
            string ModDir = "...";
            string ModDir2;
            // А вот ждем, пока инициализируется окно
            while (!IsHandleCreated);

            //Поиск id мода
            if (Is_Mode) {
                foreach (string path in MainForm.steampath) {
                    string steamworkshop = path.Replace('\\', '/') + "/steamapps/workshop/content/";
                    if (Directory.Exists(steamworkshop) && string.IsNullOrEmpty(gameid)) {
                        foreach (string wgame in Directory.GetDirectories(steamworkshop)) {
                            if (Directory.Exists(wgame + "/" + modid)) {
                                gameid = wgame.Substring(wgame.LastIndexOf('/') + 1).Trim();
                                ModDir = wgame + "/" + modid;
                                linkLabelIDMod.Invoke(new Action(() => { linkLabelIDMod.Text = gameid; }));
                                linkLabelDirMod.Invoke(new Action(() => { linkLabelDirMod.Text = ModDir; }));
                                break;
                            }
                        }
                    }
                    //Определяем имя, папку игры / мода
                    if (gameid == null) { GameName = NoticeGameErr; break; }
                    string gamename;
                    using (RegistryKey steamapps = MainForm.hostkey.OpenSubKey("SOFTWARE").OpenSubKey("Valve").OpenSubKey("Steam").OpenSubKey("Apps").OpenSubKey(gameid)) {
                        if (steamapps.GetValueNames().Length > 0) {
                            try {
                                gamename = Registry.GetValue(MainForm.hostkey + "\\SOFTWARE\\Valve\\Steam\\Apps\\" + gameid, "Name", null).ToString();
                                if (string.IsNullOrEmpty(gamename)) gamename = NoticeNotInstall;

                            } catch (Exception) {
                                gamename = NoticeNotInstall;
                            }
                        } else {
                            gamename = NoticeNotInstall;
                        }
                        //Gamename.Text = gamename;
                        GameName = gamename;
                    }

                    string gamepath = path.Replace('\\', '/') + "/steamapps/common/" + GameName;
                    if (Directory.Exists(gamepath))
                        linkLabelDirGame.Invoke(new Action(() => { linkLabelDirGame.Text = gamepath; }));
                    // Проверяем, есть ли в папке с игрой папка mods
                    if (Directory.Exists(gamepath + "/mods")) {
                        string[] files = Directory.GetDirectories(gamepath + "/mods", $"*{modid}*");
                        //linkLabelDirMod2.Text = gamepath + "/mods";
                        ModDir2 = gamepath + "/mods";
                        if (files.Length > 0)
                            ModDir2 = files[0].Replace('\\', '/');
                        else if (Directory.Exists(ModDir)) { //Попробуем найти мод по содержанию файлов в папках
                            string[] files_mod_workshopgame = Directory.GetFiles(ModDir, "*", SearchOption.TopDirectoryOnly);
                            foreach (var dirothermod in Directory.GetDirectories(gamepath + "/mods")) {
                                string[] files_mod_modgame = Directory.GetFiles(dirothermod, "*", SearchOption.TopDirectoryOnly);
                                double eps = files_mod_workshopgame.Intersect(files_mod_modgame).Count() / files_mod_workshopgame.Length;
                                if (eps > 0.70) {
                                    ModDir2 = dirothermod;
                                    break;
                                }
                            }
                        }
                        panelE4.Invoke(new Action(() => { panelE4.Visible = true; }));
                        linkLabelDirMod2.Invoke(new Action(() => { linkLabelDirMod2.Text = ModDir2; }));
                    }
                }
            } else { //Игра
                //Gamename.Text == "Не установлено." || Gamename.Text == "..." || Gamename.Text == "err" ||
                foreach (string path in MainForm.steampath) {
                    if (gameid == null) { GameName = NoticeGameErr; break; }
                    string gamename;
                    using (RegistryKey steamapps = MainForm.hostkey.OpenSubKey("SOFTWARE").OpenSubKey("Valve").OpenSubKey("Steam").OpenSubKey("Apps").OpenSubKey(gameid)) {
                        if (steamapps.GetValueNames().Length > 0) {
                            try {
                                gamename = Registry.GetValue(MainForm.hostkey + "\\SOFTWARE\\Valve\\Steam\\Apps\\" + gameid, "Name", "err").ToString();

                            } catch (Exception) {
                                gamename = NoticeNotInstall;
                            }
                        } else {
                            gamename = NoticeNotInstall;
                        }
                        GameName = gamename;
                    }

                    string gamepath = path.Replace('\\', '/') + "/steamapps/common/" + GameName;
                    if (Directory.Exists(gamepath))
                        linkLabelDirGame.Invoke(new Action(() => { linkLabelDirGame.Text = gamepath; }));
                }

            }

            if (modid != null) {
                linkLabelIDMod.Invoke(new Action(() => { linkLabelIDMod.Text = modid; }));
                linkLabelIDGame.Invoke(new Action(() => { linkLabelIDGame.Text = gameid; }));
                Gamename.Invoke(new Action(() => { Gamename.Text = GameName; }));
            } else {
                if (MainForm.is_ignore_error) { 
                    this.Invoke(new Action(() => { Close(); }));
                    return;
                }
                linkLabelIDMod.Invoke(new Action(() => { linkLabelIDMod.Text = "0"; }));
                linkLabelIDGame.Invoke(new Action(() => { linkLabelIDGame.Text = "0"; }));
                Gamename.Invoke(new Action(() => { Gamename.Text = NoticeLinkErr; }));
            }

            //Получаем иконку игры
            string fileg = null;
            string hotsteamfolder = null;
            foreach (string steamfolder in MainForm.steampath) {
                string filename = steamfolder + "/appcache/appinfo.vdf";
                if (File.Exists(filename)) {
                    fileg = File.ReadAllText(filename);
                    hotsteamfolder = steamfolder;
                    break;
                }
            }
            if (fileg != null) {
                string startsub = "name\0" + GameName.Trim() + "\0";
                foreach (int index in IndexOfMore(fileg, startsub)) {
                    string startsub2 = "clienticon\0";
                    int clienticonpos = fileg.IndexOf(startsub2, index + startsub.Length);
                    string clienticon = fileg.Substring(clienticonpos + startsub2.Length, fileg.IndexOf('\0', clienticonpos + startsub2.Length) - clienticonpos - startsub2.Length);
                    List<string> filesico = new List<string>(Directory.GetFiles(hotsteamfolder + "/steam/games"));
                    foreach (string fileico in filesico) {
                        if (fileico.IndexOf(clienticon) > -1) {
                            pictureBox1.Invoke(new Action(() => { pictureBox1.Image = new Bitmap(fileico); }));
                        }
                    }
                }
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

        private void ModInfo_Shown(object sender, EventArgs e) {
            Height = panel1.Height * toint(panel1.Visible) + groupBox1.Height * toint(groupBox1.Visible) + panel3.Height * toint(panel3.Visible) + 34 + 8;
        }

        private int toint(bool a) {
            return a ? 1 : 0;
        }
        ToolTip hint;
        Timer timer;
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Clipboard.SetText(((LinkLabel)sender).Text);
            hint = new ToolTip();
            hint.Show(NoticeClipboard, (LinkLabel)sender, 2000);
            timer = new Timer {
                Interval = 3000,
                Enabled = true
            };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            hint.Dispose();
            timer.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (linkLabelDirMod.Text != "...")
                Process.Start(linkLabelDirMod.Text);
            if (linkLabelDirMod2.Text != "...")
                Process.Start(linkLabelDirMod.Text);

        }

        private void button2_Click(object sender, EventArgs e) {
            if (linkLabelDirGame.Text != "...")
                Process.Start(linkLabelDirGame.Text);
        }

        private void contextMenuStripLink_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            var text = contextMenuStripLink.SourceControl.Text;
            OpenToolStripMenuItem.Enabled = Directory.Exists(text) || text.Contains("http");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            var text = contextMenuStripLink.SourceControl.Text;
            Process.Start(text);
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
            var text = contextMenuStripLink.SourceControl.Text;
            Clipboard.SetText(text);
        }
    }
}
