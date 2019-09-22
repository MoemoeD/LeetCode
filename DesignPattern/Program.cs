using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单例模式

            //Singleton.Singleton s1 = Singleton.Singleton.Instance();
            //Singleton.Singleton s2 = Singleton.Singleton.Instance();

            #endregion

            #region 简单工厂模式

            //SimpleFactory.Product pro = SimpleFactory.SimpleFactory.create("ProductI");
            //pro.print();

            #endregion

            #region 工厂方法模式

            //FactoryMethod.FactoryMethod facI = new FactoryMethod.CreateProductI();
            //FactoryMethod.Product proI = facI.create();
            //proI.print();

            #endregion

            Console.ReadKey();
        }
    }
}
