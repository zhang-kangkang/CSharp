using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);
            Console.WriteLine(a++);

            string str = "dog";
            try
            {
                Console.WriteLine(Convert.ToInt32(str));
            }
            catch
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
