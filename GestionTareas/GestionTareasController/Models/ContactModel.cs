using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasController.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ContactModel(int id, string name, string address, string phone, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

    }
}
