﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05工厂方法
{
    public class HistogramChart : IChartable
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图....");
        }

        public void Display()
        {
            Console.WriteLine("显示柱状图....");
        }
    }
}
