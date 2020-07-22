using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FucData2;
namespace FucData
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // 调用其他cs的方法
            //Class1.GetClass1();

            // GetData();
            Console.WriteLine(GetData());
        }

        static int GetData()
        {
            int a = 10;
            Console.WriteLine("GetData");
            return 123;
        }


        void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
