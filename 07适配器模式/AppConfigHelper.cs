using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07适配器模式
{
    public class AppConfigHelper
    {
        public static string GetAdapterName()
        {
            //通过配置文件拿到AdapterName
            string factoryName = null;
            try
            {
                //拿到在配置文件中的程序集名称  
                factoryName = ConfigurationManager.AppSettings["AdapterName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public  static object  GetAdapterInstance()
        {
            //这里是先拿到程序集名称字符串   
            string assemblyName = GetAdapterName();
            Type type = Type.GetType(assemblyName);
            var instance = Activator.CreateInstance(type);
            return instance;

        }


    }
}
