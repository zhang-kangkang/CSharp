using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace dataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(000);
            //double a = 53.545454564;
            //string a = "455\a64";
            //Console.WriteLine(a);
            //System.Console.WriteLine("000");

            // 返回值
            //string a = "abc";
            //a  = a.ToUpper();
            //Console.WriteLine(a);

            //String & StringBuilder;
            // 计时器
            //string str = String.Empty;
            //Stopwatch timeCount = new Stopwatch();
            //timeCount.Start();
            //for (int i = 0; i < 10000;i++)
            //    {
            //    str += i.ToString();
            //    }
            //timeCount.Stop();
            //Console.WriteLine(str);

            //隐式类型
            //var a = "name";
            //Console.WriteLine(a);

            // 转换函数
            //Parse
            //string a = "1";
            //int b = 2 + int.Parse(a);
            //Console.WriteLine(b);
            //TryParse,尝试转换
            string str1 = "1";
            int a1;
            if (int.TryParse(str1,out a1))
            {
                Console.WriteLine(a1);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    } 
}
