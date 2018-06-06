using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06原型模式
{
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public object Clone()
        {
            WeeklyLog obj = new WeeklyLog();
            obj.Name = Name;
            obj.Date = Date;
            obj.Content = Content;
            return obj;
        }
    }
}
