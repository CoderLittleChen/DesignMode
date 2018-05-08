using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04工厂方法模式
{
    public class EventFactory : ILogFactory
    {
        public ILog Create()
        {
            return new EventLog();
        }
    }
}
