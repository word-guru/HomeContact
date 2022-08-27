using HomeContact.Repositorys.Interfaces;
using HomeContact.Repositorys;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeContact
{
    public class ContactModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepozitory>().To<Repozitory>();
            Bind<IContactFile>().To<ContactFile>();
        }
    }
}
