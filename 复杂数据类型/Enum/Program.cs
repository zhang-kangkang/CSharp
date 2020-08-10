using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    public enum Season
    { 
        春,
        夏,
        秋,
        冬
     } 

    public enum State
    {
        online=2,
        offline,
        busy=5,
        leave
    }

    class Program
    {


        static void Main(string[] args)
        {
            State state = State.online;
            Console.WriteLine(state);
            int n = (int)state;
            Console.WriteLine(n);   //2
            Console.WriteLine((int)State.busy);     //5
            Console.WriteLine((State)2);    //online
            Console.WriteLine((State)5);    //busy



            Console.ReadKey();
        }
    }
}
