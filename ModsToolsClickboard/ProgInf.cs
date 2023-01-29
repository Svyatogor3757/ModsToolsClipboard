using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ModsToolsClipboard
{
    public partial class ProgInf : Form
    {
        public ProgInf() {
            InitializeComponent();
            MainForm.languageUse(MainForm.currentlang, this);
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
