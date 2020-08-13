using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FucData2
{
    class Class1
    {
        public static void GetClass1() {
            Console.WriteLine("class1");


        }

        public static void Test(int num,out int n1,out string s1){
            n1 = 22;
            s1 = "str";
        }

        static void Main(string[] args)
        {
            int num = 0;
            int n1;
            string s1;
            GetClass1();
            Test(num,out n1,out s1);
            Console.WriteLine(n1);
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }


}
