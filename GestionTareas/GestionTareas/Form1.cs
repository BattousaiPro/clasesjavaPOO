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
            Update_table_Front();
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
            Update_table_Front();
        }

        public void Update_table_Front()
        {
           ContactController contactController = new ContactController();
            dgvContacts.DataSource = contactController.GetContactList();
        }

        public void Form1_load(object sender, EventArgs e)
        {
            ContactController contactController = new ContactController();
            dgvContacts.DataSource = contactController.GetContactList();
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msg = "Contacto agregado con exito a la BBDD";
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
                msg = "Contacto No agregado con exito a la BBDD";
                MessageBox.Show(msg);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // pendiente.
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                tbxName.Text = dgvContacts.CurrentRow.Cells["Name"].Value.ToString();

                string name = dgvContacts.CurrentRow.Cells["Name"].Value.ToString();
                string address = dgvContacts.CurrentRow.Cells["Address"].Value.ToString();
                string phone = dgvContacts.CurrentRow.Cells["Phone"].Value.ToString();
                string email = dgvContacts.CurrentRow.Cells["Email"].Value.ToString();
                ContactModel contact = new ContactModel(name, address, phone, email);
                ContactController contactController = new ContactController();
                string isValid = contactController.DeleteContat(contact);


                MessageBox.Show("Se a Eliminado El Contacto");
                Update_table_Front();
            }
            else
            {
                MessageBox.Show("Escoger Fila a Eliminar");
            }
        }
    }
}
