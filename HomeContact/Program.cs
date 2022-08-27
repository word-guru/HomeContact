using HomeContact;
using Ninject;

IKernel kernel = new StandardKernel(new ContactModule());
var contact = kernel.Get<Actions>();

contact.Id();

Console.Write("\nДля просмотра контакта введите соответствующий id: ");
int id = int.Parse(Console.ReadLine());
Console.WriteLine("\n");
contact.Info(id);

Console.Write("\nСохранить в файл:(y/n)");
string menu = Console.ReadLine();
if (menu == "y")
    contact.Save();

Console.Write("Показать информацию из файла(y/n)");
menu = Console.ReadLine();
Console.WriteLine();
if (menu == "y")
    contact.Load();
