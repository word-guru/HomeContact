using HomeContact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeContact.Repositorys.Interfaces
{
    public interface IRepozitory
    {
        Contacts DisplayInfoContact(int id);
        List<int> GetID();
    }
}
