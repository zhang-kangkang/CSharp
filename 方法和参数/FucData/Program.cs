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
            //Console.WriteLine(GetData());

            // 传引用
            //int a = 1;
            //int b = 2;
            //Swap(ref a, ref b);Console.WriteLine("{0}\n{1}",a,b);

            // 数组是引用类型,不需要加ref
            //var list = new List<int>();
            //list.Add(1);
            //ListAdd(list); //
            //WriteList(list);

            // String类型,需要加ref
            //String a = "sss";
            //StringChange(ref a);
            //Console.WriteLine(a);

            // out
            //int num = 3;
            //Out(out num);
            //Console.WriteLine(num);

            // 泛型
            //int a = 111;
            //int b = 222;
            //Swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // params可变参数
            Console.WriteLine(Params(1, 2, 3, 4, 5)); 
        }

        void Test()
        {
            Console.WriteLine("Test");
        }

        static int GetData()
        {
            int a = 10;
            Console.WriteLine("GetData");
            return 123;
        }

        static void Swap(ref int num1,ref int num2)
        {
            int back = num1;
            num1 = num2;
            num2 = back;
        }

        static void ListAdd(List<int> list)
        {
            list.Add(2);
        }

        static void WriteList(List<int> list)
        {
            foreach(int ele in list){
                Console.WriteLine(ele);
            }
        }

        static void Out(out int num)
        {
            num = 333;
        }


        static void StringChange(ref string str)
        {
            str += "aaaaaaaaa";
        }

        static void Override(int a, string b)
        {

        }

        static void Override(string a, int b)
        {

        }

        static void Swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }

        static int Params(params int[] nums)
        {
            return nums.Sum();
        }
    }
}
