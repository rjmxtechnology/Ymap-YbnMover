﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ymapmover
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            AboutBox.Text = "v" + fvi.FileVersion;
            infoTextBox.Text = "This tool was created by Smallo for the purpose of moving maps. I noticed that a lot of custom maps " +
                "were put in the same spot, so I made this to make it easier to move them." + Environment.NewLine + Environment.NewLine +
                "Huge shoutout to dexyfex and Codewalker, if it wasn't for him none of this would be possible.";
        }
    }
}
