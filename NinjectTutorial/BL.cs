using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTutorial
{
    class BL
    {
        IProduct productObj;

        public BL(IProduct productArg)
        {
            productObj = productArg;
        }

        public void Insert()
        {
            productObj.InsertProduct();
        }
    }
}
