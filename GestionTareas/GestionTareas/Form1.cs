using System;
using System.Windows.Forms;
using GestionTareasController.Models;
using GestionTareasController;

namespace GestionTareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string address = tbxAdddress.Text;
            string phone = tbxPhone.Text;
            string email = tbxMail.Text;
            ContactModel contact = new ContactModel(name, address, phone, email);
            ContactController contactController = new ContactController();
            string isValid = contactController.DataValidate(contact);
            string msg = "Contacto agregado con exito";
            if (isValid != string.Empty)
            {
                msg = isValid;
            }
            MessageBox.Show(msg);
            
        }
    }
}
