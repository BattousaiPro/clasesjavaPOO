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
            int id = 0;
            string name = tbxName.Text;
            string address = tbxAdddress.Text;
            string phone = tbxPhone.Text;
            string email = tbxMail.Text;
            ContactModel contact = new ContactModel(id, name, address, phone, email);
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

                tbxName.Text = row.Cells[1].Value.ToString();
                tbxAdddress.Text = row.Cells[2].Value.ToString();
                tbxPhone.Text = row.Cells[3].Value.ToString();
                tbxMail.Text = row.Cells[4].Value.ToString();
            }
            catch
            {
                msg = "Contacto No agregado con exito a la BBDD";
                MessageBox.Show(msg);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // datos de la tabla.
            int id = int.Parse(dgvContacts.CurrentRow.Cells["Id"].Value.ToString());
            ContactModel contact = new ContactModel(id, tbxName.Text, tbxAdddress.Text, tbxPhone.Text, tbxMail.Text);
            ContactController contactController = new ContactController();
            string isValid = contactController.EditContact(contact);
            MessageBox.Show("Se a Actualizado El Contacto");
            Update_table_Front();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvContacts.CurrentRow.Cells["Id"].Value.ToString());
                string name = dgvContacts.CurrentRow.Cells["Name"].Value.ToString();
                string address = dgvContacts.CurrentRow.Cells["Address"].Value.ToString();
                string phone = dgvContacts.CurrentRow.Cells["Phone"].Value.ToString();
                string email = dgvContacts.CurrentRow.Cells["Email"].Value.ToString();
                ContactModel contact = new ContactModel(id, name, address, phone, email);
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

        public void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string msg = "";
            try
            {
                DataGridViewRow rows = dgvContacts.Rows[e.RowIndex];

                tbxName.Text = rows.Cells[1].Value.ToString();
                tbxAdddress.Text = rows.Cells[2].Value.ToString();
                tbxPhone.Text = rows.Cells[3].Value.ToString();
                tbxMail.Text = rows.Cells[4].Value.ToString();
            }
            catch
            {
                tbxName.Text = "";
                tbxAdddress.Text = "";
                tbxPhone.Text = "";
                tbxMail.Text = "";
                msg = "Contacto no se pudo seleccionar.";
                MessageBox.Show(msg);
            }
           
        }
    }
}
