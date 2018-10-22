using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Readonly字段的使用
{
    class Program
    {
        //readonly是
        public readonly MyClass my = new MyClass();

        static void Main(string[] args)
        {
            //const 和 readonly的用法  
            //readonly 只读 不能进行写操作，它可以是任意类型，但是必须在构造函数或者初始化器中初始化，初始化完成后不能被修改
            //readonly 只读 不能进行写操作，它所修饰的成员变量可以是任意类型，但是必须在构造函数或者初始化器中初始化，初始化完成后不能被修改 
            //const 不能用来修改类对象 const为编译时常量

            //readonly   只读   不能进行写操作，它可以是任意类型，但是必须在构造函数或者初始化器中初始化      初始化完成后不能被修改
            //const    不能用来修改类对象，const为编译时常量

        }
    }
    class MyClass
    {

    }
}
