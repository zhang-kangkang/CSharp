using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct User {    //命名注意规范
            public string _name;
            public int _width;
            public int _height;
            public Sex _sex;    //使用枚举类型
        }

        public enum Sex {
            男,
            女
        }

        static void Main(string[] args)
        {
            User boy;
            boy._name = "Tom"; 
            Console.WriteLine(boy._name);
            boy._sex = Sex.男;
            Console.WriteLine(boy._sex);

            Console.ReadKey();
        }
    }
}
