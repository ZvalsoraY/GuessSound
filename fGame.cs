﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessSound
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        public fGame()
        {
            InitializeComponent();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
        }

        void MakeMusic()
        {
            int n = rnd.Next(0, Victorina.list.Count);
            WMP.URL = Victorina.list[n];
            //WMP.Ctlcontrols.play();
            Victorina.list.RemoveAt(n);
            lblMelodyCount.Text = Victorina.list.Count.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
