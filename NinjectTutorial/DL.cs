using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTutorial
{
    class DL:IProduct
    {
        public string InsertProduct()
        {
            return "Product from the DL";
        }
    }
}
