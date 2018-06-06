using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //原型Prototype  应用：用户创建表单的时候，可以选择创建空白表单 也可以创建模板
            //原理：将一个原型对象传给要发动创建的对象，这个要发动创建的对象通过请求原型对象   克隆自己来实现创建过程

            Client.V1();
            Console.ReadKey();

        }
    }
}
