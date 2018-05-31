using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂 可以理解为生产一个对象的一个类  
            //缺点是   如果有新增需求  代码需要频繁的改动
            ICoat coat = SimpleFactory.GetCoat("business");
            coat.GetYourCoat();
            Console.ReadKey();
        }
    }
}
