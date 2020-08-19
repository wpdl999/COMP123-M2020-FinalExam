﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SpalshTimer_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            this.Hide();
            SpalshTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SpalshTimer.Enabled = true;
        }
    }
}
