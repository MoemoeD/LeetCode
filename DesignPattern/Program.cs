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

            #region 抽象工厂模式

            //AbstractFactory.AbstractFactory facPlus = new AbstractFactory.CreateProductI();
            //AbstractFactory.ProductPlus proI = facPlus.createPlus();
            //proI.print();

            #endregion

            #region 建造者模式

            //Builder.Manager manager = new Builder.Manager();
            //Builder.Builder builderI = new Builder.BuilderI();
            //Builder.Builder builderII = new Builder.BuilderII();

            //manager.Construct(builderI);

            //Builder.Product proI = builderI.getProduct();
            //proI.showMsg();

            #endregion

            #region 观察者模式

            //Observer.Server server = new Observer.ServerI("ServerI Info");
            //Observer.ClientI client = new Observer.ClientI("ClientI");

            //server.Add(client);
            //server.Send();

            //server.Remove(client);
            //server.Send();

            #endregion

            Console.ReadKey();
        }
    }
}
