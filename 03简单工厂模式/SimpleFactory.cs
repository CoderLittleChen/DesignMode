using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂模式
{
    public class SimpleFactory
    {
        public static ICoat GetCoat(string type)
        {
            ICoat coat;
            if (type == "business")
            {
                coat = new BusinessCoat();
            }
            else
            {
                coat = new FashionCoat();
            }
            return coat;
        }
    }
}
