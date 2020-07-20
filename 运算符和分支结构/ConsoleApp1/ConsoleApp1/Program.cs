using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a++和++a
            //int a = 0;
            //int b;
            //a++;
            //++a;
            //a += 1;
            //b = ++a;
            //Console.WriteLine(b);
            //Console.WriteLine(a );

            //Const常量
            //const int a = 1;
            //int b;
            //b = 1 + a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // 运算表达式
            //Console.WriteLine(1+2 > 2);
            //Console.WriteLine("{0}+{1}>{2}",1,2,3);
            //三元表达式
            int a = 1;
            int b = 2;
            Console.WriteLine("LargeNum:"+ (a > b ? a : b));
        }
    }
}
