using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07建造者模式
{
    public abstract class Builder
    {
        //创建产品对象  
        protected Product product = new Product();
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();

        //返回产品对象  返回产品对象  
        public Product GetResult()
        {
            return product;
        }

    }   
}
