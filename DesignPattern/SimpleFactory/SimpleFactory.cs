using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class SimpleFactory
    {
        public static Product create(string pro)
        {
            Product p = null;
            if (pro == "ProductI")
            {
                p = new ProductI();
            }
            else if (pro == "ProductII")
            {
                p = new ProductII();
            }
            return p;
        }
    }

    public abstract class Product
    {
        public abstract void print();
    }

    public class ProductI : Product
    {
        public override void print()
        {
            Console.WriteLine("Print ProductI");
        }
    }

    public class ProductII : Product
    {
        public override void print()
        {
            Console.WriteLine("Print ProductII");
        }
    }

}
