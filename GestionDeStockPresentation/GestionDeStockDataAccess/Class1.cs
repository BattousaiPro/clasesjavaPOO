using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStockDataAccess
{
    public class Class1
    {
        BD_INVENTORY_LISTEntities ctx = new BD_INVENTORY_LISTEntities();

        public List<TBL_INVENTORY> getContactList()
        {
            return ctx.TBL_INVENTORY.ToList();
        }

        public TBL_INVENTORY getContactById(int idContact)
        {
            return ctx.TBL_INVENTORY
                .Where(x => x.ID_INVENTORY.Equals(idContact))
                .FirstOrDefault();
        }

        public string CreateContact(TBL_INVENTORY contact)
        {
            string response = string.Empty;
            try
            {
                ctx.TBL_INVENTORY.Add(contact);
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

        public string EditContact(TBL_INVENTORY contact)
        {
            string response = string.Empty;
            try
            {
                TBL_INVENTORY dataChange = ctx.TBL_INVENTORY.Where(x => x.ID_INVENTORY.Equals(contact.ID_INVENTORY)).FirstOrDefault();

                dataChange.ELECTRONICA_INVENTORY = contact.ELECTRONICA_INVENTORY;
                dataChange.MUEBLES_INVENTORY = contact.MUEBLES_INVENTORY;
                dataChange.LINEABLANCA__INVENTORY = contact.LINEABLANCA__INVENTORY;
                // LINEABLANCA__INVENTORY ESTE NOMBRE ESTA MALO ... TIENE UN C¿DLOBLE GUION BAJO .
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

        public string DeleteContact(TBL_INVENTORY contact)
        {
            string response = string.Empty;
            try
            {
                TBL_INVENTORY dataRemove = ctx.TBL_INVENTORY
                .Where(x => x.ID_INVENTORY.Equals(contact.ID_INVENTORY))
                .FirstOrDefault();
                ctx.TBL_INVENTORY.Remove(dataRemove);
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
    }
}

