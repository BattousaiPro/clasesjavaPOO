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
                string.IsNullOrEmpty(contact.Email))
            {
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
                NameContact = contact.Name,
                PhoneContact = contact.Phone,
                AddressContact = contact.Address,
                EmailContact = contact.Email,
            };
            string request = contacDA.CreateContact(dataSave);
            if(request != string.Empty)
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
                ContactModel itemContact = new ContactModel( contact.NameContact, contact.AddressContact, contact.PhoneContact, contact.EmailContact);
                response.Add(itemContact);
          }
            return response;


        }

    }
}
