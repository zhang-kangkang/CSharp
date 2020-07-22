using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义数组
            int[] a = new int[20];
            //a[0] = a[1] = 1;

            // for循环，斐波那契数列
            //for(int i = 2; i <= 10; i++)
            //{
            //    a[i] = a[i - 1] + a[i - 2];
            //    Console.WriteLine(a[i]);
            //}

            // 创建随机数
            var r = new Random();
            for (int i = 0; i < 20; i++)
            {
                a[i] = r.Next(20);
                Console.WriteLine(a[i]);
            }

            // 获取前两个最大的值
            //int top1 = a[0], top2 = a[0];
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (a[i] < top2)
            //    {
            //        continue;
            //    }
            //    if (a[i] > top1)
            //    {
            //        top2 = top1;
            //        top1 = a[i];
            //    }
            //    else
            //    {
            //        top2 = a[i];
            //    }
            //}
            //Console.WriteLine("top1:" + top1);
            //Console.WriteLine("top2:" + top2);

            // foreach循环
            Console.WriteLine("foreach");
            foreach (int ele in a)
            {
                Console.WriteLine(ele);
            }

        }
        
    }
}
