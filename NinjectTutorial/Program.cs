using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;

namespace NinjectTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            IProduct _productObject = _kernel.Get<IProduct>();
            BL blObject = new BL(_productObject);
            blObject.Insert();
            Console.ReadLine();
        }
    }
}
