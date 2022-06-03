using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxResult_TextChanged(object sender, EventArgs e)
        {
            string age = txbAge.Text;
            try
            {
                if (string.IsNullOrEmpty(age))
                {
                    MessageBox.Show("Debe ingresar un valor");
                }
                else
                {
                    if (Convert.ToInt32(age) >= 18)
                    {
                        tbxResult.Text = "Mayor de edad";
                    }
                    else
                    {
                        tbxResult.Text = "Menor de edad";
                    }
                }
            }
            catch (Exception)
            {
                txbAge.Clear();
                MessageBox.Show("Debe ingresar valores numericos");
            }
        }

            private void txbAge_TextChanged(object sender, EventArgs e)
            {
                tbxResult.Clear();
            }
        }
    }
}

