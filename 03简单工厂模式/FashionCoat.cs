﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂模式
{
    public class FashionCoat : ICoat
    {
        public void GetYourCoat()
        {
            Console.WriteLine("时尚大衣");
        }
    }
}
