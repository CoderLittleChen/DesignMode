using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {  //多思考  关于反射的使用   熟练掌握
            //工厂方法模式 弥补了简单工厂的缺点
            //想要完全  实现需求变更 不修改代码， 需要通过反射  读取配置文件来实现
            ILogFactory logFactory = new FileFactory();
            ILog log = logFactory.Create();
            log.Write();
            //load 里面的参数是程序集名称 也就是生成的dll文件名称     没有后缀
            //loadFile 参数是dll文件所在路径
            //CreateInstance 参数是程序集中的类名称
            //Assembly.Load("11").CreateInstance("11");
            Console.ReadKey();
        }
    }
}
