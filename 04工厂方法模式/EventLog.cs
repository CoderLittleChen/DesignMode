using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04工厂方法模式
{
    public class EventLog:ILog
    {
        public void Write()
        {
            Console.WriteLine("Event  Log  Success");
        }
    }
}
