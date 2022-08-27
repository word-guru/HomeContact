using HomeContact.Models;
using HomeContact.Repositorys.Interfaces;

namespace HomeContact
{
    public class Actions
    {
        private readonly IRepozitory _repozitory;
        private readonly IContactFile _contactFile;
        private Contacts _contact;
        private List<int> _id;

        public Actions(IRepozitory repozitory, IContactFile contactFile)
        {
            _repozitory = repozitory;
            _contactFile = contactFile;
            _contact = new Contacts();
            _id = new List<int>();
        }

        public void Info(int id)
        {
            _contact = _repozitory.DisplayInfoContact(id);
            Console.WriteLine($"Name: {_contact.Name}");
            Console.WriteLine($"Phone: {_contact.Phone}");
            Console.WriteLine($"Alternative phone: {_contact.AlternativePhone}");
            Console.WriteLine($"Email: {_contact.Email}");
            Console.WriteLine($"Description: {_contact.Description}");
        }

        public void Id()
        {
            _id = _repozitory.GetID();
            Console.WriteLine("ID контактов:");
            foreach (var id in _id)
                Console.WriteLine($"{id}");
        }
        public void Save()
        {
            string text = "";
            text = $"Name: {_contact.Name}\nPhone: {_contact.Phone}\nAlternative phone: {_contact.AlternativePhone}\n" +
                $"Email: {_contact.Email}\nDescription: {_contact.Description}";
            _contactFile.SaveFile(text);
        }
        public void Load()
        {
            _contactFile.LoadFile();
        }
    }
}
