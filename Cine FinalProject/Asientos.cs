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
    public partial class Asientos : Form
    {
        public static string movie;

        public static string Movie
        {
   
            get { return movie; }
            set { movie = value; }
        }
        public Asientos()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            if (Movie == "0")
            {
                llenarAsientos(Datos.jojo);
            }
            else if (Movie == "1")
            {
                llenarAsientos(Datos.outh);
            }
            else if (Movie == "2")
            {
                llenarAsientos(Datos.joker);
            }
            else if (Movie == "3")
            {
                llenarAsientos(Datos.mil);
            }
        }

        private void llenarAsientos(int[,] array)
        {
            if (array[0, 0] == 1) {
                button1.Enabled = false;
                button1.BackColor = Color.Red;
                Datos.dinamic[0, 0] = array[0, 0];
            }if(array[0, 1] == 1)
            {
                button2.Enabled = false;
                button2.BackColor = Color.Red;
                Datos.dinamic[0, 1] = array[0, 1];
            }
            if(array[0, 2] == 1)
            {
                button3.Enabled = false;
                button3.BackColor = Color.Red;
                Datos.dinamic[0, 2] = array[0, 2];
            }
            if(array[1, 0] == 1)
            {
                button4.Enabled = false;
                button4.BackColor = Color.Red;
                Datos.dinamic[1, 0] = array[1, 0];
            }
            if(array[1, 1] == 1)
            {
                button5.Enabled = false;
                button5.BackColor = Color.Red;
                Datos.dinamic[1, 1] = array[1, 1];
            }
            if(array[1, 2] == 1)
            {
                button6.Enabled = false;
                button6.BackColor = Color.Red;
                Datos.dinamic[1, 2] = array[1, 2];
            }
            if(array[2, 0] == 1)
            {
                button7.Enabled = false;
                button7.BackColor = Color.Red;
                Datos.dinamic[2, 0] = array[2, 0];
            }
            if(array[2, 1] == 1)
            {
                button8.Enabled = false;
                button8.BackColor = Color.Red;
                Datos.dinamic[2, 1] = array[2, 1];
            }
            if(array[2, 2] == 1)
            {
                button9.Enabled = false;
                button9.BackColor = Color.Red;
                Datos.dinamic[2, 2] = array[2, 2];
            }
            if(array[3, 0] == 1)
            {
                button10.Enabled = false;
                button10.BackColor = Color.Red;
                Datos.dinamic[3, 0] = array[3, 0];
            }
            if(array[3, 1] == 1)
            {
                button11.Enabled = false;
                button11.BackColor = Color.Red;
                Datos.dinamic[3, 1] = array[3, 1];
            }
            if(array[3, 2] == 1)
            {
                button12.Enabled = false;
                button12.BackColor = Color.Red;
                Datos.dinamic[3, 2] = array[3, 2];
            }
            if(array[4, 0] == 1)
            {
                button13.Enabled = false;
                button13.BackColor = Color.Red;
                Datos.dinamic[4, 0] = array[4, 0];
            }
            if(array[4, 1] == 1)
            {
                button14.Enabled = false;
                button14.BackColor = Color.Red;
                Datos.dinamic[4, 1] = array[4, 1];
            }
            if(array[4, 2] == 1)
            {
                button15.Enabled = false;
                button15.BackColor = Color.Red;
                Datos.dinamic[4, 2] = array[4, 2];
            }
            if(array[5, 0] == 1)
            {
                button16.Enabled = false;
                button16.BackColor = Color.Red;
                Datos.dinamic[5, 0] = array[5, 0];
            }
            if(array[5, 1] == 1)
            {
                button17.Enabled = false;
                button17.BackColor = Color.Red;
                Datos.dinamic[5, 1] = array[5, 1];
            }
            if(array[5, 2] == 1)
            {
                button18.Enabled = false;
                button18.BackColor = Color.Red;
                Datos.dinamic[5, 2] = array[5, 2];
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Datos.limpiarDinamic();
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            Datos.dinamic[0,0] = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            Datos.dinamic[0, 1] = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            Datos.dinamic[0, 2] = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            Datos.dinamic[1, 0] = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
            Datos.dinamic[1, 1] = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Green;
            Datos.dinamic[1, 2] = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Green;
            Datos.dinamic[2, 0] = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Green;
            Datos.dinamic[2, 1] = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Green;
            Datos.dinamic[2, 2] = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Green;
            Datos.dinamic[3, 0] = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Green;
            Datos.dinamic[3, 1] = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Green;
            Datos.dinamic[3, 2] = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Green;
            Datos.dinamic[4, 0] = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Green;
            Datos.dinamic[4, 1] = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Green;
            Datos.dinamic[4, 2] = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
            Datos.dinamic[5, 0] = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Green;
            Datos.dinamic[5, 1] = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Green;
            Datos.dinamic[5, 2] = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            comprobacionPago cp = new comprobacionPago();
            cp.Show();
            this.Hide();
        }
    }
}
