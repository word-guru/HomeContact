using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeContact.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AlternativePhone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
