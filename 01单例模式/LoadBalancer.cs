using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单例模式
{
    //假装自己是一个负载均衡器
    public class LoadBalancer
    {
        //定义一个标识 确保进程同步
        private static readonly object locker = new object();
        //静态类对象
        public static LoadBalancer instance = null;
        //服务器集合
        private IList<CustomServer> serverList = null;
        //私有构造函数  单例模式中的  lazy load  懒加载
        private LoadBalancer()
        {
            serverList = new List<CustomServer>();
        }
        //公共静态方法 返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            //这里通过双重锁定 
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }
        // 添加一台Server
        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }

        // 移除一台Server
        public void RemoveServer(string serverName)
        {
            foreach (var server in serverList)
            {
                if (server.Name.Equals(serverName))
                {
                    serverList.Remove(server);
                    break;
                }
            }
        }

        // 获得一台Server - 使用随机数获取
        private Random rand = new Random();
        public CustomServer GetServer()
        {
            int index = rand.Next(serverList.Count);

            return serverList[index];
        }

    }
}
