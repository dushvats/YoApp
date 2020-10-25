using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYoTestApp.Application.Interfaces;
using YoYoTestApp.Application.Services;
using YoYoTestApp.Core.Interfaces;
using YoYoTestApp.Infrastructure.Repository;

namespace YoYoTestApp.Infrastructure.Data
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IShuttleRepository>().To<ShuttleRepository>();
            Bind<IShuttleService>().To<ShuttleService>();
        }
    }
}
