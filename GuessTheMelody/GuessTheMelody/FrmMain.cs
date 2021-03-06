﻿using System;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class FrmMain : Form
    {
        private FrmParams frmParams = new FrmParams();
        private FrmGame frmGame = new FrmGame();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            frmParams.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmGame.ShowDialog();
        }
    }
}
