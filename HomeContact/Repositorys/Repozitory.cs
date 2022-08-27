using HomeContact.Models;
using HomeContact.Repositorys.Interfaces;

namespace HomeContact.Repositorys
{
    public class Repozitory : IRepozitory
    {
        private List<Contacts> contact = new List<Contacts>
        {
            new Contacts{
                Id = 0,
                Name = "Вася",
                Phone = "(800)-111-11-11",
                AlternativePhone = "(800)-111-11-12",
                Email = "v&co@.ru",
                Description = "Служба безопастности банка"
            },
            new Contacts{
                Id = 1,
                Name = "Петя",
                Phone = "(800)-111-22-22",
                AlternativePhone = "(800)-111-22-23",
                Email = "p&co@.ru",
                Description = "Менеджер банка"
            },
            new Contacts{
                Id = 2,
                Name = "Иван",
                Phone = "(800)-111-33-33",
                AlternativePhone = "(800)-111-33-34",
                Email = "i&co@.ru",
                Description = "Служба безопастности банка"
            }
        };
        public Contacts DisplayInfoContact(int id)
        {
            return contact[id];
        }

        public List<int> GetID()
        {
            return contact.Select(x => x.Id).ToList();
        }
    }
}
