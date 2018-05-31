using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05工厂方法
{
    public class ChartFactory
    {
        //根据type类型来创建chart实例
        public static IChartable GetChart(string type)
        {
            IChartable chart = null;
            if (type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                chart = new HistogramChart();
                Console.WriteLine("初始化设置柱状图....");
            }
            else if (type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                chart = new LineChart();
                Console.WriteLine("初始化设置折线图....");
            }
            else if (type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                chart = new PieChart();
                Console.WriteLine("初始化设置饼状图....");
            }
            return chart;
        }
    }
}
