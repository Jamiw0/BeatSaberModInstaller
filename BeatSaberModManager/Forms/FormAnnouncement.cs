﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatSaberModManager.Forms
{
    public partial class FormAnnouncement : MaterialForm
    {
        public FormAnnouncement()
        {
            InitializeComponent();
        }

        private void FormAnnouncement_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModAssistant_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Assistant/ModAssistant");
        }

        private void buttonBeatDrop_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/StarGazer1258/BeatDrop");
        }

        private void buttonNoThanks_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
