using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            //可以从读取配置文件来获取要创建的图表
            string chartType = ConfigurationManager.AppSettings["chartType"].ToString();
            if (string.IsNullOrEmpty(chartType))
            { 
                return;
            }

            //核心逻辑是  在工厂类中实现创建产品的功能
            IChartable chart = ChartFactory.GetChart(chartType);
            if (chart != null)
            {  
                chart.Display();
            }
            Console.ReadKey();
        }
    }
}
