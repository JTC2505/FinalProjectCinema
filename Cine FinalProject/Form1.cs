using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Datos.User && textBox2.Text == Datos.Password)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else if(textBox1.Text == Datos.User && textBox2.Text != Datos.Password)
            {
                MessageBox.Show("Contraseña no valida");
            }
            else
            {
                MessageBox.Show("Información de logueo no valida");
            }
        }
    }
}
