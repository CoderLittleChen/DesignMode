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
            //First  Version
            WeeklyLog log = new WeeklyLog();
            log.Name = "Victor";
            log.Date = "第一周";
            log.Content = "这周没什么事，挺闲的";
            PrintWeekLog(log);

            //Second Version  Based  on  First Version
            WeeklyLog log2 = log.Clone() as WeeklyLog;
            log2.Date = "第二周";
            PrintWeekLog(log2);

            WeeklyLog log3 = log.Clone() as WeeklyLog;
            log3.Date = "第三周";
            PrintWeekLog(log3);
        }

    }
}
