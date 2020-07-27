using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {

            user uu = new user();
            uu.name = "tom";
            uu.age = 19;
            Console.WriteLine(uu.name);
            Console.WriteLine(uu.age);
        }

        struct user
        {
            public string name;
            public int age;
        }
    }
}
