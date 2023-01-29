
namespace ModsToolsClipboard
{
    partial class ModInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelE6 = new System.Windows.Forms.Panel();
            this.linkLabelLinkMod = new System.Windows.Forms.LinkLabel();
            this.contextMenuStripLink = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLink = new System.Windows.Forms.Label();
            this.panelE5 = new System.Windows.Forms.Panel();
            this.linkLabelDirGame = new System.Windows.Forms.LinkLabel();
            this.labelGameDir = new System.Windows.Forms.Label();
            this.panelE4 = new System.Windows.Forms.Panel();
            this.linkLabelDirMod2 = new System.Windows.Forms.LinkLabel();
            this.labelModeDir2 = new System.Windows.Forms.Label();
            this.panelE3 = new System.Windows.Forms.Panel();
            this.linkLabelDirMod = new System.Windows.Forms.LinkLabel();
            this.labelModDir = new System.Windows.Forms.Label();
            this.panelE2 = new System.Windows.Forms.Panel();
            this.linkLabelIDGame = new System.Windows.Forms.LinkLabel();
            this.labelGameID = new System.Windows.Forms.Label();
            this.panelE1 = new System.Windows.Forms.Panel();
            this.linkLabelIDMod = new System.Windows.Forms.LinkLabel();
            this.labelModeID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelE0 = new System.Windows.Forms.Panel();
            this.Modname = new System.Windows.Forms.LinkLabel();
            this.labelModeName = new System.Windows.Forms.Label();
            this.labelGameNameDesk = new System.Windows.Forms.Label();
            this.Gamename = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOpenModDir = new System.Windows.Forms.Button();
            this.buttonOpenGameDir = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelE6.SuspendLayout();
            this.contextMenuStripLink.SuspendLayout();
            this.panelE5.SuspendLayout();
            this.panelE4.SuspendLayout();
            this.panelE3.SuspendLayout();
            this.panelE2.SuspendLayout();
            this.panelE1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelE0.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panelE6);
            this.groupBox1.Controls.Add(this.panelE5);
            this.groupBox1.Controls.Add(this.panelE4);
            this.groupBox1.Controls.Add(this.panelE3);
            this.groupBox1.Controls.Add(this.panelE2);
            this.groupBox1.Controls.Add(this.panelE1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подробнее";
            this.groupBox1.Visible = false;
            // 
            // panelE6
            // 
            this.panelE6.Controls.Add(this.linkLabelLinkMod);
            this.panelE6.Controls.Add(this.labelLink);
            this.panelE6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelE6.Location = new System.Drawing.Point(3, 131);
            this.panelE6.Name = "panelE6";
            this.panelE6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE6.Size = new System.Drawing.Size(518, 23);
            this.panelE6.TabIndex = 12;
            // 
            // linkLabelLinkMod
            // 
            this.linkLabelLinkMod.ContextMenuStrip = this.contextMenuStripLink;
            this.linkLabelLinkMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelLinkMod.Location = new System.Drawing.Point(92, 0);
            this.linkLabelLinkMod.Name = "linkLabelLinkMod";
            this.linkLabelLinkMod.Size = new System.Drawing.Size(426, 23);
            this.linkLabelLinkMod.TabIndex = 0;
            this.linkLabelLinkMod.TabStop = true;
            this.linkLabelLinkMod.Text = "...";
            this.linkLabelLinkMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelLinkMod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // contextMenuStripLink
            // 
            this.contextMenuStripLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CopyToolStripMenuItem});
            this.contextMenuStripLink.Name = "contextMenuStripLink";
            this.contextMenuStripLink.Size = new System.Drawing.Size(140, 48);
            this.contextMenuStripLink.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripLink_Opening);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // labelLink
            // 
            this.labelLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLink.Location = new System.Drawing.Point(1, 0);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(91, 23);
            this.labelLink.TabIndex = 0;
            this.labelLink.Text = "Link:";
            this.labelLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelE5
            // 
            this.panelE5.Controls.Add(this.linkLabelDirGame);
            this.panelE5.Controls.Add(this.labelGameDir);
            this.panelE5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelE5.Location = new System.Drawing.Point(3, 108);
            this.panelE5.Name = "panelE5";
            this.panelE5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE5.Size = new System.Drawing.Size(518, 23);
            this.panelE5.TabIndex = 11;
            // 
            // linkLabelDirGame
            // 
            this.linkLabelDirGame.ContextMenuStrip = this.contextMenuStripLink;
            this.linkLabelDirGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelDirGame.Location = new System.Drawing.Point(92, 0);
            this.linkLabelDirGame.Name = "linkLabelDirGame";
            this.linkLabelDirGame.Size = new System.Drawing.Size(426, 23);
            this.linkLabelDirGame.TabIndex = 0;
            this.linkLabelDirGame.TabStop = true;
            this.linkLabelDirGame.Text = "...";
            this.linkLabelDirGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelDirGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelGameDir
            // 
            this.labelGameDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGameDir.Location = new System.Drawing.Point(1, 0);
            this.labelGameDir.Name = "labelGameDir";
            this.labelGameDir.Size = new System.Drawing.Size(91, 23);
            this.labelGameDir.TabIndex = 0;
            this.labelGameDir.Text = "Game Path:";
            this.labelGameDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelE4
            // 
            this.panelE4.Controls.Add(this.linkLabelDirMod2);
            this.panelE4.Controls.Add(this.labelModeDir2);
            this.panelE4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelE4.Location = new System.Drawing.Point(3, 85);
            this.panelE4.Name = "panelE4";
            this.panelE4.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE4.Size = new System.Drawing.Size(518, 23);
            this.panelE4.TabIndex = 10;
            this.panelE4.Visible = false;
            // 
            // linkLabelDirMod2
            // 
            this.linkLabelDirMod2.ContextMenuStrip = this.contextMenuStripLink;
            this.linkLabelDirMod2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelDirMod2.Location = new System.Drawing.Point(92, 0);
            this.linkLabelDirMod2.Name = "linkLabelDirMod2";
            this.linkLabelDirMod2.Size = new System.Drawing.Size(426, 23);
            this.linkLabelDirMod2.TabIndex = 0;
            this.linkLabelDirMod2.TabStop = true;
            this.linkLabelDirMod2.Text = "...";
            this.linkLabelDirMod2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelDirMod2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelModeDir2
            // 
            this.labelModeDir2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModeDir2.Location = new System.Drawing.Point(1, 0);
            this.labelModeDir2.Name = "labelModeDir2";
            this.labelModeDir2.Size = new System.Drawing.Size(91, 23);
            this.labelModeDir2.TabIndex = 0;
            this.labelModeDir2.Text = "Mod Path 2:";
            this.labelModeDir2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelE3
            // 
            this.panelE3.Controls.Add(this.linkLabelDirMod);
            this.panelE3.Controls.Add(this.labelModDir);
            this.panelE3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelE3.Location = new System.Drawing.Point(3, 62);
            this.panelE3.Name = "panelE3";
            this.panelE3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE3.Size = new System.Drawing.Size(518, 23);
            this.panelE3.TabIndex = 9;
            // 
            // linkLabelDirMod
            // 
            this.linkLabelDirMod.ContextMenuStrip = this.contextMenuStripLink;
            this.linkLabelDirMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelDirMod.Location = new System.Drawing.Point(92, 0);
            this.linkLabelDirMod.Name = "linkLabelDirMod";
            this.linkLabelDirMod.Size = new System.Drawing.Size(426, 23);
            this.linkLabelDirMod.TabIndex = 0;
            this.linkLabelDirMod.TabStop = true;
            this.linkLabelDirMod.Text = "...";
            this.linkLabelDirMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelDirMod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelModDir
            // 
            this.labelModDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModDir.Location = new System.Drawing.Point(1, 0);
            this.labelModDir.Name = "labelModDir";
            this.labelModDir.Size = new System.Drawing.Size(91, 23);
            this.labelModDir.TabIndex = 0;
            this.labelModDir.Text = "Mod Path:";
            this.labelModDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelE2
            // 
            this.panelE2.Controls.Add(this.linkLabelIDGame);
            this.panelE2.Controls.Add(this.labelGameID);
            this.panelE2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelE2.Location = new System.Drawing.Point(3, 39);
            this.panelE2.Name = "panelE2";
            this.panelE2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE2.Size = new System.Drawing.Size(518, 23);
            this.panelE2.TabIndex = 8;
            // 
            // linkLabelIDGame
            // 
            this.linkLabelIDGame.ContextMenuStrip = this.contextMenuStripLink;
            this.linkLabelIDGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelIDGame.Location = new System.Drawing.Point(92, 0);
            this.linkLabelIDGame.Name = "linkLabelIDGame";
            this.linkLabelIDGame.Size = new System.Drawing.Size(426, 23);
            this.linkLabelIDGame.TabIndex = 0;
            this.linkLabelIDGame.TabStop = true;
            this.linkLabelIDGame.Text = "0";
            this.linkLabelIDGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelIDGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelGameID
            // 
            this.labelGameID.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGameID.Location = new System.Drawing.Point(1, 0);
            this.labelGameID.Name = "labelGameID";
            this.labelGameID.Size = new System.Drawing.Size(91, 23);
            this.labelGameID.TabIndex = 0;
            this.labelGameID.Text = "Game ID:";
            this.labelGameID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelE1
            // 
            this.panelE1.Controls.Add(this.linkLabelIDMod);
            this.panelE1.Controls.Add(this.labelModeID);
            this.panelE1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelE1.Location = new System.Drawing.Point(3, 16);
            this.panelE1.Name = "panelE1";
            this.panelE1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE1.Size = new System.Drawing.Size(518, 23);
            this.panelE1.TabIndex = 6;
            // 
            // linkLabelIDMod
            // 
            this.linkLabelIDMod.ContextMenuStrip = this.contextMenuStripLink;
            this.linkLabelIDMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelIDMod.Location = new System.Drawing.Point(92, 0);
            this.linkLabelIDMod.Name = "linkLabelIDMod";
            this.linkLabelIDMod.Size = new System.Drawing.Size(426, 23);
            this.linkLabelIDMod.TabIndex = 0;
            this.linkLabelIDMod.TabStop = true;
            this.linkLabelIDMod.Text = "0";
            this.linkLabelIDMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelIDMod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelModeID
            // 
            this.labelModeID.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModeID.Location = new System.Drawing.Point(1, 0);
            this.labelModeID.Name = "labelModeID";
            this.labelModeID.Size = new System.Drawing.Size(91, 23);
            this.labelModeID.TabIndex = 0;
            this.labelModeID.Text = "Mod ID:";
            this.labelModeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelE0);
            this.panel1.Controls.Add(this.labelGameNameDesk);
            this.panel1.Controls.Add(this.Gamename);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 171);
            this.panel1.TabIndex = 1;
            // 
            // panelE0
            // 
            this.panelE0.Controls.Add(this.Modname);
            this.panelE0.Controls.Add(this.labelModeName);
            this.panelE0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelE0.Location = new System.Drawing.Point(0, 148);
            this.panelE0.Name = "panelE0";
            this.panelE0.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelE0.Size = new System.Drawing.Size(524, 23);
            this.panelE0.TabIndex = 10;
            this.panelE0.Visible = false;
            // 
            // Modname
            // 
            this.Modname.ContextMenuStrip = this.contextMenuStripLink;
            this.Modname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modname.Location = new System.Drawing.Point(95, 0);
            this.Modname.Name = "Modname";
            this.Modname.Size = new System.Drawing.Size(429, 23);
            this.Modname.TabIndex = 0;
            this.Modname.TabStop = true;
            this.Modname.Text = "ModName";
            // 
            // labelModeName
            // 
            this.labelModeName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModeName.Location = new System.Drawing.Point(1, 0);
            this.labelModeName.Name = "labelModeName";
            this.labelModeName.Size = new System.Drawing.Size(94, 23);
            this.labelModeName.TabIndex = 0;
            this.labelModeName.Text = "Mod Name:";
            this.labelModeName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelGameNameDesk
            // 
            this.labelGameNameDesk.AutoSize = true;
            this.labelGameNameDesk.Location = new System.Drawing.Point(143, 12);
            this.labelGameNameDesk.Name = "labelGameNameDesk";
            this.labelGameNameDesk.Size = new System.Drawing.Size(67, 13);
            this.labelGameNameDesk.TabIndex = 7;
            this.labelGameNameDesk.Text = "Game name:";
            // 
            // Gamename
            // 
            this.Gamename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gamename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gamename.Location = new System.Drawing.Point(143, 32);
            this.Gamename.Name = "Gamename";
            this.Gamename.Size = new System.Drawing.Size(375, 108);
            this.Gamename.TabIndex = 6;
            this.Gamename.Text = "Game";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 128);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ModsToolsClipboard.Properties.Resources.empty_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.buttonOpenModDir);
            this.panel3.Controls.Add(this.buttonOpenGameDir);
            this.panel3.Controls.Add(this.buttonClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 32);
            this.panel3.TabIndex = 0;
            // 
            // buttonOpenModDir
            // 
            this.buttonOpenModDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenModDir.Location = new System.Drawing.Point(189, 6);
            this.buttonOpenModDir.Name = "buttonOpenModDir";
            this.buttonOpenModDir.Size = new System.Drawing.Size(121, 23);
            this.buttonOpenModDir.TabIndex = 0;
            this.buttonOpenModDir.Text = "Open Mod folder";
            this.buttonOpenModDir.UseVisualStyleBackColor = true;
            this.buttonOpenModDir.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonOpenGameDir
            // 
            this.buttonOpenGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenGameDir.Location = new System.Drawing.Point(316, 6);
            this.buttonOpenGameDir.Name = "buttonOpenGameDir";
            this.buttonOpenGameDir.Size = new System.Drawing.Size(121, 23);
            this.buttonOpenGameDir.TabIndex = 1;
            this.buttonOpenGameDir.Text = "Open Game folder";
            this.buttonOpenGameDir.UseVisualStyleBackColor = true;
            this.buttonOpenGameDir.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(443, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 400);
            this.Name = "ModInfo";
            this.Text = "ModInfo";
            this.Shown += new System.EventHandler(this.ModInfo_Shown);
            this.groupBox1.ResumeLayout(false);
            this.panelE6.ResumeLayout(false);
            this.contextMenuStripLink.ResumeLayout(false);
            this.panelE5.ResumeLayout(false);
            this.panelE4.ResumeLayout(false);
            this.panelE3.ResumeLayout(false);
            this.panelE2.ResumeLayout(false);
            this.panelE1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelE0.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGameNameDesk;
        private System.Windows.Forms.Label Gamename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonOpenModDir;
        private System.Windows.Forms.Button buttonOpenGameDir;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.LinkLabel linkLabelIDMod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelE6;
        private System.Windows.Forms.LinkLabel linkLabelLinkMod;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Panel panelE5;
        private System.Windows.Forms.LinkLabel linkLabelDirGame;
        private System.Windows.Forms.Label labelGameDir;
        private System.Windows.Forms.Panel panelE4;
        private System.Windows.Forms.LinkLabel linkLabelDirMod2;
        private System.Windows.Forms.Label labelModeDir2;
        private System.Windows.Forms.Panel panelE3;
        private System.Windows.Forms.LinkLabel linkLabelDirMod;
        private System.Windows.Forms.Label labelModDir;
        private System.Windows.Forms.Panel panelE2;
        private System.Windows.Forms.LinkLabel linkLabelIDGame;
        private System.Windows.Forms.Label labelGameID;
        private System.Windows.Forms.Panel panelE1;
        private System.Windows.Forms.Label labelModeID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLink;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.Panel panelE0;
        private System.Windows.Forms.LinkLabel Modname;
        private System.Windows.Forms.Label labelModeName;
    }
}