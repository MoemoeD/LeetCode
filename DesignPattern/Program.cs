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

            Singleton.Singleton s1 = Singleton.Singleton.Instance();
            Singleton.Singleton s2 = Singleton.Singleton.Instance();

            #endregion

        }
    }
}
