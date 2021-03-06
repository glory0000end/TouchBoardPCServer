﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchPadPCServer
{
    public partial class UnVisibleForm : Form
    {
        public UnVisibleForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            monitor.Stop();
            this.Close();
        }

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            monitor.Start();
        }

        private void ToolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            monitor.Stop();
        }

        private void ToolStripMenuItemSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingFrm = new SettingForm();
            settingFrm.ShowDialog();
        }

        private MonitorServer monitor = new MonitorServer();
    }
}
