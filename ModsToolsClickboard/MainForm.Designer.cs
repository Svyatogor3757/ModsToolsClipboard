
namespace ModsToolsClipboard
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonAnalysis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labellinkdesk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDesk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.buttonPasteBufer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDirsSteam = new System.Windows.Forms.Button();
            this.buttonLang = new System.Windows.Forms.Button();
            this.checkBoxIgnoreErr = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveWindowSize = new System.Windows.Forms.CheckBox();
            this.checkBoxMoreInf = new System.Windows.Forms.CheckBox();
            this.checkBoxAnalysis = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_err = new System.Windows.Forms.Label();
            this.labelErrHelp = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.timer_a = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.CopyrightNotice = new System.Windows.Forms.LinkLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.languageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.languageContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnalysis
            // 
            this.buttonAnalysis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAnalysis.Location = new System.Drawing.Point(179, 86);
            this.buttonAnalysis.Name = "buttonAnalysis";
            this.buttonAnalysis.Size = new System.Drawing.Size(85, 23);
            this.buttonAnalysis.TabIndex = 0;
            this.buttonAnalysis.Text = "Analysis";
            this.buttonAnalysis.UseVisualStyleBackColor = true;
            this.buttonAnalysis.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 19);
            this.textBox1.MaxLength = 500000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 61);
            this.textBox1.TabIndex = 1;
            // 
            // labellinkdesk
            // 
            this.labellinkdesk.AutoSize = true;
            this.labellinkdesk.Location = new System.Drawing.Point(12, 3);
            this.labellinkdesk.Name = "labellinkdesk";
            this.labellinkdesk.Size = new System.Drawing.Size(226, 13);
            this.labellinkdesk.TabIndex = 2;
            this.labellinkdesk.Text = "Link(s) to the mod(s) from the steam workshop:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDesk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 69);
            this.panel1.TabIndex = 2;
            // 
            // labelDesk
            // 
            this.labelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDesk.Location = new System.Drawing.Point(0, 0);
            this.labelDesk.Name = "labelDesk";
            this.labelDesk.Size = new System.Drawing.Size(450, 69);
            this.labelDesk.TabIndex = 0;
            this.labelDesk.Text = "The program analyzes links from the Steam Workshop in order to find the location " +
    "of the mod on the computer";
            this.labelDesk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_help);
            this.panel2.Controls.Add(this.buttonPasteBufer);
            this.panel2.Controls.Add(this.labellinkdesk);
            this.panel2.Controls.Add(this.buttonAnalysis);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 116);
            this.panel2.TabIndex = 0;
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.BackColor = System.Drawing.Color.White;
            this.button_help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Location = new System.Drawing.Point(415, 20);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(21, 21);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "? Справка";
            this.button_help.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            this.button_help.MouseHover += new System.EventHandler(this.button_help_MouseHover);
            // 
            // buttonPasteBufer
            // 
            this.buttonPasteBufer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPasteBufer.Location = new System.Drawing.Point(15, 86);
            this.buttonPasteBufer.Name = "buttonPasteBufer";
            this.buttonPasteBufer.Size = new System.Drawing.Size(117, 23);
            this.buttonPasteBufer.TabIndex = 2;
            this.buttonPasteBufer.Text = "Paste from Buffer";
            this.buttonPasteBufer.UseVisualStyleBackColor = true;
            this.buttonPasteBufer.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.buttonDirsSteam);
            this.panel3.Controls.Add(this.buttonLang);
            this.panel3.Controls.Add(this.checkBoxIgnoreErr);
            this.panel3.Controls.Add(this.checkBoxSaveWindowSize);
            this.panel3.Controls.Add(this.checkBoxMoreInf);
            this.panel3.Controls.Add(this.checkBoxAnalysis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 76);
            this.panel3.TabIndex = 1;
            // 
            // buttonDirsSteam
            // 
            this.buttonDirsSteam.Location = new System.Drawing.Point(260, 50);
            this.buttonDirsSteam.Name = "buttonDirsSteam";
            this.buttonDirsSteam.Size = new System.Drawing.Size(184, 23);
            this.buttonDirsSteam.TabIndex = 7;
            this.buttonDirsSteam.Text = "Steam Paths";
            this.buttonDirsSteam.UseVisualStyleBackColor = true;
            this.buttonDirsSteam.Click += new System.EventHandler(this.button1_LinkClicked);
            // 
            // buttonLang
            // 
            this.buttonLang.Location = new System.Drawing.Point(260, 26);
            this.buttonLang.Name = "buttonLang";
            this.buttonLang.Size = new System.Drawing.Size(184, 23);
            this.buttonLang.TabIndex = 7;
            this.buttonLang.Text = "Language (язык)";
            this.buttonLang.UseVisualStyleBackColor = true;
            this.buttonLang.Click += new System.EventHandler(this.buttonLang_Click);
            // 
            // checkBoxIgnoreErr
            // 
            this.checkBoxIgnoreErr.AutoSize = true;
            this.checkBoxIgnoreErr.Location = new System.Drawing.Point(260, 6);
            this.checkBoxIgnoreErr.Name = "checkBoxIgnoreErr";
            this.checkBoxIgnoreErr.Size = new System.Drawing.Size(125, 17);
            this.checkBoxIgnoreErr.TabIndex = 6;
            this.checkBoxIgnoreErr.Text = "Ignore analysis errors";
            this.checkBoxIgnoreErr.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreErr.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxSaveWindowSize
            // 
            this.checkBoxSaveWindowSize.AutoSize = true;
            this.checkBoxSaveWindowSize.Location = new System.Drawing.Point(12, 56);
            this.checkBoxSaveWindowSize.Name = "checkBoxSaveWindowSize";
            this.checkBoxSaveWindowSize.Size = new System.Drawing.Size(111, 17);
            this.checkBoxSaveWindowSize.TabIndex = 5;
            this.checkBoxSaveWindowSize.Text = "Save window size";
            this.checkBoxSaveWindowSize.UseVisualStyleBackColor = true;
            this.checkBoxSaveWindowSize.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxMoreInf
            // 
            this.checkBoxMoreInf.AutoSize = true;
            this.checkBoxMoreInf.Checked = true;
            this.checkBoxMoreInf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMoreInf.Location = new System.Drawing.Point(12, 32);
            this.checkBoxMoreInf.Name = "checkBoxMoreInf";
            this.checkBoxMoreInf.Size = new System.Drawing.Size(104, 17);
            this.checkBoxMoreInf.TabIndex = 1;
            this.checkBoxMoreInf.Text = "More information";
            this.checkBoxMoreInf.UseVisualStyleBackColor = true;
            this.checkBoxMoreInf.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxAnalysis
            // 
            this.checkBoxAnalysis.AutoSize = true;
            this.checkBoxAnalysis.Location = new System.Drawing.Point(12, 6);
            this.checkBoxAnalysis.Name = "checkBoxAnalysis";
            this.checkBoxAnalysis.Size = new System.Drawing.Size(163, 17);
            this.checkBoxAnalysis.TabIndex = 0;
            this.checkBoxAnalysis.Text = "Analyze links to the clipboard";
            this.checkBoxAnalysis.UseVisualStyleBackColor = true;
            this.checkBoxAnalysis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.labelErrHelp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 141);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.label_err);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(450, 128);
            this.panel8.TabIndex = 6;
            // 
            // label_err
            // 
            this.label_err.AutoEllipsis = true;
            this.label_err.AutoSize = true;
            this.label_err.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_err.Location = new System.Drawing.Point(0, 0);
            this.label_err.MaximumSize = new System.Drawing.Size(450, 0);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(0, 13);
            this.label_err.TabIndex = 4;
            // 
            // labelErrHelp
            // 
            this.labelErrHelp.AutoSize = true;
            this.labelErrHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrHelp.Location = new System.Drawing.Point(0, 0);
            this.labelErrHelp.Name = "labelErrHelp";
            this.labelErrHelp.Size = new System.Drawing.Size(80, 13);
            this.labelErrHelp.TabIndex = 0;
            this.labelErrHelp.Text = "The main errors";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listBox1);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 132);
            this.panel5.TabIndex = 9;
            this.panel5.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(362, 112);
            this.listBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(362, 20);
            this.textBox2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonClose);
            this.panel6.Controls.Add(this.buttonSave);
            this.panel6.Controls.Add(this.buttonDelete);
            this.panel6.Controls.Add(this.buttonAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(362, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(88, 132);
            this.panel6.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClose.Location = new System.Drawing.Point(4, 82);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(79, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(4, 106);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelete.Location = new System.Drawing.Point(7, 35);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Remove";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(7, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer_a
            // 
            this.timer_a.Interval = 1000;
            this.timer_a.Tick += new System.EventHandler(this.timer_a_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Mod Info";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.CopyrightNotice);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 584);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 19);
            this.panel7.TabIndex = 10;
            // 
            // CopyrightNotice
            // 
            this.CopyrightNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyrightNotice.LinkColor = System.Drawing.Color.Gray;
            this.CopyrightNotice.Location = new System.Drawing.Point(3, 3);
            this.CopyrightNotice.Name = "CopyrightNotice";
            this.CopyrightNotice.Size = new System.Drawing.Size(447, 13);
            this.CopyrightNotice.TabIndex = 6;
            this.CopyrightNotice.TabStop = true;
            this.CopyrightNotice.Text = "Copyright Notice";
            this.CopyrightNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyrightNotice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 603);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(450, 0);
            this.panel11.TabIndex = 11;
            // 
            // languageContextMenuStrip
            // 
            this.languageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.languageContextMenuStrip.Name = "languageContextMenuStrip";
            this.languageContextMenuStrip.Size = new System.Drawing.Size(113, 26);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 635);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "MainForm";
            this.Text = "Анализ мода";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.languageContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnalysis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labellinkdesk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDesk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPasteBufer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxMoreInf;
        private System.Windows.Forms.CheckBox checkBoxAnalysis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelErrHelp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_err;
        private System.Windows.Forms.Timer timer_a;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxSaveWindowSize;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.LinkLabel CopyrightNotice;
        private System.Windows.Forms.CheckBox checkBoxIgnoreErr;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonDirsSteam;
        private System.Windows.Forms.ContextMenuStrip languageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Button buttonLang;
    }
}

