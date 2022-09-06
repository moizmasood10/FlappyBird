﻿using FlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Bird.ImageLocation = @"C:\Users\Moiz\Pictures\Project Resources\birdgif.gif";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            easy.Visible = false;
            med.Visible = false;
            hard.Visible = false;
        }


        private void startbutton_Click(object sender, EventArgs e)
        {
            easy.Visible = true;
            med.Visible = true;
            hard.Visible = true;
            med.BringToFront();
            easy.BringToFront();
            hard.BringToFront();
            startbutton.Dispose();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void med_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void easy_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void flash_Tick(object sender, EventArgs e)
        {
            if (startbutton.Visible == true)
            {
                startbutton.Visible = false;
            }
            else
            {
                startbutton.Visible = true;
            }
        }
    }
}
