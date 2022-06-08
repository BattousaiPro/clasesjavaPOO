using System;
using System.Windows.Forms;
using GestionTareasController.Models;
using GestionTareasController;
using System.Data;

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
            Actualizar_tabla();
            
        }
        public void Actualizar_tabla()
        {
           ContactController contactController = new ContactController();
            dgvContacts.DataSource = contactController.GetContactList();
        }
        public void Form1_load(object sender, EventArgs e)
        {
            ContactController contactController = new ContactController();
            dgvContacts.DataSource = contactController.GetContactList();
        }
        public void btmDelete_Click(object sender, EventArgs e)
        {
           if (dgvContacts.SelectedRows.Count > 0)
           {
                tbxName.Text = dgvContacts.CurrentRow.Cells["Name"].Value.ToString();
                MessageBox.Show("Se a Eliminado El Contacto");
                Actualizar_tabla();
           }
           else
           {
                MessageBox.Show("Escoger Fila a Eliminar");
           }
        }
        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvContacts.Rows[e.RowIndex];

                tbxName.Text = row.Cells[0].Value.ToString();
                tbxAdddress.Text = row.Cells[1].Value.ToString();
                tbxPhone.Text = row.Cells[2].Value.ToString();
                tbxMail.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                
            }
        }
    }
}
