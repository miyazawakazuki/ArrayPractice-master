﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);
        int vvx = rand.Next(-20, 21);
        int vvy = rand.Next(-20, 21);
        int vvxx = rand.Next(-20, 21);
        int vvyy = rand.Next(-20, 21);

        int score = 100;

        public Form1()
        {
            InitializeComponent();

            /*label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score--;
            scoreLabel.Text = $"Score {score:000}";

            label1.Left += vx;
            label1.Top += vy;
            label2.Left += vvx;
            label2.Top += vvx;
            label3.Left += vvxx;
            label3.Top += vvyy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if (label2.Left < 0)
            {
                vvx = Math.Abs(vvx);
            }
            if (label2.Top < 0)
            {
                vvy = Math.Abs(vvy);
            }
            if (label2.Right > ClientSize.Width)
            {
                vvx = -Math.Abs(vvx);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vvy = -Math.Abs(vvy);
            }

            if (label3.Left < 0)
            {
                vvxx = Math.Abs(vvxx);
            }
            if (label3.Top < 0)
            {
                vvyy = Math.Abs(vvyy);
            }
            if (label3.Right > ClientSize.Width)
            {
                vvxx = -Math.Abs(vvxx);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vvyy = -Math.Abs(vvyy);
            }

            Point fpos = PointToClient(MousePosition);

            if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                label1.Visible = false;
            }


            if ((fpos.X >= label2.Left)
                && (fpos.X < label2.Right)
                && (fpos.Y >= label2.Top)
                && (fpos.Y < label2.Bottom))
            {
                label2.Visible = false;
            }


            if ((fpos.X >= label3.Left)
                && (fpos.X < label3.Right)
                && (fpos.Y >= label3.Top)
                && (fpos.Y < label3.Bottom))
            {
                label3.Visible = false;
            }

            if(     (label1.Visible==false)
                &&(label2.Visible==false)
                &&(label3.Visible==false))
            {
                timer1.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}