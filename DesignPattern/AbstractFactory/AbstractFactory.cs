using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Product create();

        public abstract ProductPlus createPlus();
    }

    public class CreateProductI : AbstractFactory
    {
        public override Product create()
        {
            return new ProductI();
        }

        public override ProductPlus createPlus()
        {
            return new ProductPlusI();
        }
    }

    public class CreateProductII : AbstractFactory
    {
        public override Product create()
        {
            return new ProductII();
        }

        public override ProductPlus createPlus()
        {
            return new ProductPlusII();
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

    public abstract class ProductPlus
    {
        public abstract void print();
    }

    public class ProductPlusI : ProductPlus
    {
        public override void print()
        {
            Console.WriteLine("Print ProductPlusI");
        }
    }

    public class ProductPlusII : ProductPlus
    {
        public override void print()
        {
            Console.WriteLine("Print ProductPlusII");
        }
    }

}
