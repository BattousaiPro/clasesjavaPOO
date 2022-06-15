using GestionTareasController.Models;
using GestionTareasDataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasController
{
    public class ContactController
    {
        public string DataValidate(ContactModel contact)
        {
            string response = string.Empty;

            if (string.IsNullOrEmpty(contact.Name) ||
                string.IsNullOrEmpty(contact.Address) ||
                string.IsNullOrEmpty(contact.Phone) ||
                string.IsNullOrEmpty(contact.Email)
                ) {
                response = "Datos ingresados no validos, revisar";

            } else
            {
                response =  CreateContat(contact);
            }
            return response;
        }

        private string CreateContat(ContactModel contact)
        {
            string response = string.Empty;
            var contacDA = new ContactDataAccess();
            TBL_CONTACT dataSave = new TBL_CONTACT()
            {
                NAME_CONTACT = contact.Name,
                PHONE_CONTACT = contact.Phone,
                ADDRESS_CONTACT = contact.Address,
                MAIL_CONTACT = contact.Email,
            };
            string request = contacDA.CreateContact(dataSave);

            if(request != string.Empty)
            {
                response = request;
            }
            return response;
        }

        public string DeleteContat(ContactModel contact)
        {
            string response = string.Empty;
            var contacDA = new ContactDataAccess();
            TBL_CONTACT dataSave = new TBL_CONTACT()
            {
                ID_CONTACT = contact.Id
            };
            string request = 
                contacDA.DeleteContact(dataSave);

            if (request != string.Empty)
            {
                response = request;
            }
            return response;
        }

        public string EditContact(ContactModel contact)
        {
            string response = string.Empty;
            var contacDA = new ContactDataAccess();
            TBL_CONTACT dataSave = new TBL_CONTACT()
            {
                ID_CONTACT = contact.Id,
                NAME_CONTACT = contact.Name,
                PHONE_CONTACT = contact.Phone,
                ADDRESS_CONTACT = contact.Address,
                MAIL_CONTACT = contact.Email,
            };
            string request = 
                contacDA.EditContact(dataSave);

            if (request != string.Empty)
            {
                response = request;
            }
            return response;
        }

        public List<ContactModel> GetContactList()
        {
            List<ContactModel> response = new List<ContactModel>();
            var contacDA = new ContactDataAccess();
            List<TBL_CONTACT> contacData = contacDA.GetContactList();
            foreach(TBL_CONTACT contact in contacData)
            {
                ContactModel itemContact = new ContactModel(contact.ID_CONTACT, contact.NAME_CONTACT, contact.ADDRESS_CONTACT, contact.PHONE_CONTACT, contact.MAIL_CONTACT);
                response.Add(itemContact);
            }
            return response;
        }

    }
}
