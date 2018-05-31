using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式属于创建型模式，3个要点：某个类只能有一个实例，它必须自行创建这个实例，它必须自行向整个系统提供这个实例
            LoadBalancer balancer, balancer2, balancer3;
            balancer = LoadBalancer.GetLoadBalancer();
            balancer2 = LoadBalancer.GetLoadBalancer();
            balancer3 = LoadBalancer.GetLoadBalancer();

            // 判断负载均衡器是否相同
            if (balancer == balancer2 && balancer == balancer3 && balancer2 == balancer3)
            {
                Console.WriteLine("^_^ : 服务器负载均衡器是唯一的！");
            }

            // 增加服务器
            balancer.AddServer(new CustomServer() { Name = "Server 1" });
            balancer.AddServer(new CustomServer() { Name = "Server 2" });
            balancer.AddServer(new CustomServer() { Name = "Server 3" });
            balancer.AddServer(new CustomServer() { Name = "Server 4" });

            // 模拟客户端请求的分发
            for (int i = 0; i < 10; i++)
            {
                CustomServer server = balancer.GetServer();
                Console.WriteLine("该请求已分配至 : " + server.Name);
            }

            Console.ReadKey();

        }
    }
}
