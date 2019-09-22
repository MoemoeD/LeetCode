using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Manager
    {
        public void Construct(Builder b)
        {
            b.buildPartI();
            b.buildPartII();
        }
    }

    public class Product
    {
        private IList<string> parts = new List<string>();

        public void add(string part)
        {
            parts.Add(part);
        }

        public void showMsg()
        {
            Console.WriteLine("Start...");
            foreach (var part in parts)
            {
                Console.WriteLine(part + "...");
            }
            Console.WriteLine("End...");
        }
    }

    public abstract class Builder
    {
        public abstract void buildPartI();

        public abstract void buildPartII();

        public abstract Product getProduct();
    }

    public class BuilderI : Builder
    {
        private Product pro = new Product();

        public override void buildPartI()
        {
            pro.add("Add PartI");
        }

        public override void buildPartII()
        {
            pro.add("Add PartII");
        }

        public override Product getProduct()
        {
            return pro;
        }
    }

    public class BuilderII : Builder
    {
        private Product pro = new Product();

        public override void buildPartI()
        {
            pro.add("Add PartI");
        }

        public override void buildPartII()
        {
            pro.add("Add PartII");
        }

        public override Product getProduct()
        {
            return pro;
        }
    }

}
