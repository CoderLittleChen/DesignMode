using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07适配器模式
{
    /// <summary>
    /// 目标接口：抽象成绩操作类
    /// </summary>
    public interface IScoreOperation
    {
        //成绩排序
        int[] Sort(int[] array);
        //成绩查找
        int Search(int[] array, int key);
    }

}
