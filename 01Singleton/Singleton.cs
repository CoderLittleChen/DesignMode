using System;

namespace _01Singleton
{
    public class Singleton
    {
        //单例模式的定义：确保一个类只有一个实例，并提供一个全局访问点

        //定义静态变量保存类的实例
        private static Singleton uniqueInstance;
        //定义一个标识确保线程同步  多线程问题
        private static readonly object locker = new object();
        //定义私有构造函数 使外界不能创建类实例
        private Singleton()
        {
        }
        //定义共有方法 提供全局访问点
        public static Singleton GetInstance()
        {
            //当第一个线程运行到这里的时候，此时会对locker对象加锁
            //当第二个线程运行该方法的时候，首先检测locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            //lock语句运行完之后（即线程运行完之后） 会对该对象解锁

            //这里添加双重锁定的原因是 当第一个线程创建了对象之后，后来的线程只需要判断对象的状态
            //没有必要对线程辅助对象加锁之后再去判断
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    //判断类的实例是否存在  不存在则创建
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                    }
                }
            }
            return uniqueInstance;
        }

    }
}
