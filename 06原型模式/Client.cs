using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06原型模式
{
    public class Client
    {
        public static void PrintWeekLog(WeeklyLog log)
        {
            if (log == null)
            {
                return;
            }
            Console.WriteLine("----------- start : M公司个人工作周报 -----------");
            Console.WriteLine("周次：{0}", log.Date);
            Console.WriteLine("员工：{0}", log.Name);
            Console.WriteLine("内容：{0}", log.Content);
            Console.WriteLine("----------- end : M公司个人工作周报 -----------");
        }

        public static void V1()
        {
            //深复制和浅赋值
            //浅赋值：赋值一个对象的时候，仅仅赋值原始对象中所以的非静态类型成员和所有的引用类型成员的引用
            //           新对象将和原对象共享所有引用类型成员的实际对象 
            //深赋值：不仅复制所有非静态类型成员，还要复制所有引用类型成员的实际对象

            //First  Version
            WeeklyLog log = new WeeklyLog();
            log.Name = "Victor";
            log.Date = "第一周";
            log.Content = "这周没什么事，挺闲的";
            PrintWeekLog(log);

            //Second Version  Based  on  First Version
            
            //这里是先通过 log对象 Client    将其属性全部复制，然后这个吧杜
            WeeklyLog log2 = log.Clone() as WeeklyLog;
            log2.Date = "第二周";
            PrintWeekLog(log2);


            //Third Version Based on First 
            WeeklyLog log3 = log.Clone() as WeeklyLog;
            log3.Date = "第三周";
            PrintWeekLog(log3);
        }

    }
}
