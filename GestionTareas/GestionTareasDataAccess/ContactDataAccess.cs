using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasDataAccess
{
    public class ContactDataAccess
    {
        BD_CONTACT_LISTEntities ctx = new BD_CONTACT_LISTEntities();

        public List<TBL_CONTACT> GetContactList()
        {
           return ctx.TBL_CONTACT.ToList();
        }

        public TBL_CONTACT getContactById(int idContact)
        {
            return ctx.TBL_CONTACT
                .Where(x => x.ID_CONTACT.Equals(idContact))
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
            TBL_CONTACT dataChange = ctx.TBL_CONTACT.Where(x => x.ID_CONTACT.Equals(contact.ID_CONTACT)).FirstOrDefault();

            dataChange.NAME_CONTACT = contact.NAME_CONTACT;
            dataChange.PHONE_CONTACT = contact.PHONE_CONTACT;
            dataChange.MAIL_CONTACT = contact.MAIL_CONTACT;
            dataChange.ADDRESS_CONTACT = contact.ADDRESS_CONTACT;
            ctx.SaveChanges();
        }

        public void DeleteContact(TBL_CONTACT contact)
        {
            TBL_CONTACT dataRemove = ctx.TBL_CONTACT
                .Where(x => x.ID_CONTACT.Equals(contact.ID_CONTACT))
                .FirstOrDefault();
            ctx.TBL_CONTACT.Remove(dataRemove);
            ctx.SaveChanges();
        }
    }
}
