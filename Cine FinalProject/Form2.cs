﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Asientos.Movie = "0";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "1";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "2";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "3";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "0";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "1";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "2";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Asientos.Movie = "3";
            Asientos asi = new Asientos();
            asi.Show();
            this.Hide();
        }
    }
}
