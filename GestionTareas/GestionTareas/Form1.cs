using System;
using System.Windows.Forms;
using GestionTareasController.Models;
using GestionTareasController;
using System.IO;

namespace GestionTareas
{
    public partial class Form1 : Form
    {
        private List<Contacts> Contacts = new List<Contacts>();
        private int indece = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contacts persona = new Contacts();
            string name = tbxName.Text;
            string address = tbxAdddress.Text;
            string phone = tbxPhone.Text;
            string email = tbxMail.Text;
            Contacts.Add(persona);
            actualizaVista();
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
        private void actualizaVista()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = Contacts;
            dgvContacts.ClearSelection();
        }

        private void dgvContacts_DoubleClick(object sender, EventArgs e)
        {
            DataGridViemRow renglon = dgvContacts.SelectedRows[0];
            indice = dgvContacts.Rows.IndexOf(renglon);
            Contacts persona = Contacts[indice];
            tbxName.Text = persona.Name;
            tbxAdddress.Text = persona.Address;
            tbxPhone.Text = persona.Phone; 
            tbxMail.Text = persona.mail;
        }
        private void limpiarCampos() 
        {
            tbxAdddress.Text = null;
            tbxNombre.Text = null;
            tbxPhones.Text = null;
            tbxMail.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (indice>- 1)
            {
                Contacts.RemoveAt.(indice);
                actualizaVista();
                limpiarCampos();
                indice = -1;
            }
            else
            {
                MessageBox.Show("Selecciones el registre a borrar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StringReader lector = new StringReader("Agenda.txt");
                string linea;
                while((linea = lector.ReadLine()) != null)
                 {
                    int posicion;
                    Contacts persona = new Contacts();
                    posicion = linea.IndexOf(" | ");
                    persona.Name = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf(" | ");
                    persona.Apellido = linea.Substring (0, posicion);
                    linea=linea.Substring (posicion + 1);
                    posicion = linea.IndexOf(" | ");
                    persona.phone = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf(" | ");
                    persona = email.Substring(0, posicion);
                    Contacts.Add(persona);

                }
                lector.Close();
                actualizaVista
            }
            catch (Exception ec)
            {
                Contacts.Writeline("Exception: " + ec.Message);
            }
            finally
            {
                Console.WriteLine("Ejecucion Fianlizada");
            }
        }
    }
}
