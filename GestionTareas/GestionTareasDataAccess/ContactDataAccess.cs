using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasDataAccess
{
    public class ContactDataAccess
    {
        DB_CONTACT_LISTEntities ctx = new DB_CONTACT_LISTEntities();

        public List<TBL_CONTACT> GetContactList()
        {
           return ctx.TBL_CONTACT.ToList();
        }

        public TBL_CONTACT getContactById(int idContact)
        {
            return ctx.TBL_CONTACT
                .Where(x => x.idContactList.Equals(idContact))
                .FirstOrDefault();
        }

        public string CreateContact(TBL_CONTACT contact)
        {
            string response = string.Empty;
            try
            {
                ctx.TBL_CONTACT.Add(contact);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                response = e.Message;
            }
            finally
            {
                ctx.Dispose();
            }
           return response;
        }

        public void EditContact(TBL_CONTACT contact)
        {
            TBL_CONTACT dataChange = ctx.TBL_CONTACT.
                 Where(x => x.idContactList.Equals(contact.idContactList))
                 .FirstOrDefault();

            dataChange.NameContact = contact.NameContact;
            dataChange.PhoneContact = contact.PhoneContact;
            ctx.SaveChanges();
        }

        public void DeleteContact(TBL_CONTACT contact)
        {
            TBL_CONTACT dataRemove = ctx.TBL_CONTACT.
                 Where(x => x.idContactList.Equals(contact.idContactList))
                 .FirstOrDefault();
            ctx.TBL_CONTACT.Remove(dataRemove);
            ctx.SaveChanges();
        }
    }
}
