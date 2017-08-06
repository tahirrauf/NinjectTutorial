using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTutorial
{
    public class NinjectBinding: Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IProduct>().To<DL>();
        }
    }
}
