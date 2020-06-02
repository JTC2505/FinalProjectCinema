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
    public partial class comprobacionPago : Form
    {
        public comprobacionPago()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.limpiarDinamic();
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pago pay = new pago();
            pay.Show();
            this.Hide();


        }

        private void comprobacionPago_Load(object sender, EventArgs e)
        {
            int precio = 0, total = 0, cantidad = 0, tota = 0, totb= 0;
            if (Asientos.Movie == "0") {
                precio = 15;
                for (int i = 0; i <= 5; i++) {
                    for (int j = 0; j <= 2; j++) {
                        if (Datos.jojo[i, j] == 1) {
                            tota++;
                        }
                        if (Datos.dinamic[i, j] == 1)
                        {
                            totb++;
                        }
                    }
                }
                cantidad = totb - tota;
            }
            else if (Asientos.Movie == "1")
            {
                precio = 20;
                for (int i = 0; i <= 5; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (Datos.outh[i, j] == 1)
                        {
                            tota++;
                        }
                        if (Datos.dinamic[i, j] == 1)
                        {
                            totb++;
                        }
                    }
                }
                cantidad = totb - tota;
            }
            else if (Asientos.Movie == "2")
            {
                precio = 25;
                for (int i = 0; i <= 5; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (Datos.joker[i, j] == 1)
                        {
                            tota++;
                        }
                        if (Datos.dinamic[i, j] == 1)
                        {
                            totb++;
                        }
                    }
                }
                cantidad = totb - tota;
            }
            else if (Asientos.Movie == "3")
            {
                precio = 15;
                for (int i = 0; i <= 5; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (Datos.mil[i, j] == 1)
                        {
                            tota++;
                        }
                        if (Datos.dinamic[i, j] == 1)
                        {
                            totb++;
                        }
                    }
                }
                cantidad = totb - tota;
            }
            total = cantidad * precio;

            label8.Text = total.ToString();
            label6.Text = precio.ToString();
            label2.Text = cantidad.ToString();
        }
    }
}
