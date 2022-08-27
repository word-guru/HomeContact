using HomeContact.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeContact.Repositorys
{
    public class ContactFile : IContactFile
    {
        public void LoadFile()
        {
            string path = @"E:\ASP.NET\HomeContact\HomeContact\File\TextFile.txt";
            var regex = new Regex(@"[a-zA-Z]+");
            foreach (var item in File.ReadLines(path))
            {
                if (regex.IsMatch(item))
                {
                    var str = item.Split(':');
                    Console.WriteLine($"{str[1]}");
                }
            }
        }

        public void SaveFile(string text)
        {
            string path = @"E:\ASP.NET\HomeContact\HomeContact\File\Contact.txt";
            File.WriteAllText(path, text);
        }
    }
}
