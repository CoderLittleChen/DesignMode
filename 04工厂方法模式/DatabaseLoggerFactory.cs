using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04工厂方法模式
{
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            ILogger logger = new DatabaseLogger();
            return logger;
        }
    }
}
