using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //The  life   I   Want,there  is  no  short  cut        我想要的生活，没有捷径可言      
            //merge合并        merge合并
            //使用GitHub，如果你修改了fork的项目，可以发起一个Pull  Request的请求，将改动提交
            //这个时候   原作者就会看到谁谁谁提交了代码，并会看到你的Comment，可以选择是否merge到他原有的项目中
            //如果你发现  开源项目中存在一个Bug，那么可以为这个项目新建一个issue，告知作者Bug信息，作者修改之后  然后可以回复你


            //适配器模式：将一个接口转换成客户希望的另一个接口，使接口不兼容的那些类可以一起工作
            //适配器模式的实现就是把客户类的请求转换为对应的适配者的相应接口的调用，也就是说，当客户类调用适配器的方法时
            //在适配器类的内部将调用适配器着类的方法，这个过程对于客户类来说是透明的


            //我们之间的距离
            IScoreOperation operation = (IScoreOperation)AppConfigHelper.GetAdapterInstance();
            if (operation == null)
            {
                return;
            }

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("测试成绩排序结果：");
            result = operation.Sort(scores);

            foreach (int s in result)
            {
                Console.WriteLine("{0}，", s.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("查找是否有90分的人");
            score = operation.Search(scores, 90);
            if (score == -1)
            {
                Console.WriteLine("抱歉，没找到");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在90分选手~~~");
            }

            Console.WriteLine("查找是否有92分的人");
            score = operation.Search(scores, 92);
            if (score == -1)
            {
                Console.WriteLine("抱歉，没找到");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在92分选手");
            }

            Console.ReadKey();


        }
    }
}
