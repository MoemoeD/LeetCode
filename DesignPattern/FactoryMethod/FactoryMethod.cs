using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class FactoryMethod
    {
        public abstract Product create();
    }

    public class CreateProductI : FactoryMethod
    {
        public override Product create()
        {
            return new ProductI();
        }
    }

    public class CreateProductII : FactoryMethod
    {
        public override Product create()
        {
            return new ProductII();
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
