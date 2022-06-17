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

        public List<TBL_INVENTORY> getInventoryList()
        {
            return ctx.TBL_INVENTORY.ToList();
        }

        public TBL_INVENTORY getInventoryById(int idInventory)
        {
            return ctx.TBL_INVENTORY
                .Where(x => x.ID_INVENTORY.Equals(idInventory))
                .FirstOrDefault();
        }

        public string CreateInventory(TBL_INVENTORY contact)
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

        public string EditInventory(TBL_INVENTORY inventory)
        {
            string response = string.Empty;
            try
            {
                TBL_INVENTORY dataChange = ctx.TBL_INVENTORY.Where(x => x.ID_INVENTORY.Equals(inventory.ID_INVENTORY)).FirstOrDefault();

                dataChange.ELECTRONICA_INVENTORY = inventory.ELECTRONICA_INVENTORY;
                dataChange.MUEBLES_INVENTORY = inventory.MUEBLES_INVENTORY;
                dataChange.LINEABLANCA_INVENTORY = inventory.LINEABLANCA_INVENTORY;
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

        public string DeleteInventory(TBL_INVENTORY inventory)
        {
            string response = string.Empty;
            try
            {
                TBL_INVENTORY dataRemove = ctx.TBL_INVENTORY
                .Where(x => x.ID_INVENTORY.Equals(inventory.ID_INVENTORY))
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

