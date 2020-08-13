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
            //State state = State.online;
            //Console.WriteLine(state);
            //int n = (int)state;
            // 枚举转int
            //Console.WriteLine((int)State.busy);     //5
            // int转枚举
            //Console.WriteLine((State)2);    //online
            //Console.WriteLine((State)5);    //busy

            //string转enum
            //string str = "online666";
            //State state =  (State)State.Parse(typeof(State), str);
            //Console.WriteLine(state);

            //应用
            Console.Write("请输入您的在线状态:");
            string input = Console.ReadLine();
            State state = (State)State.Parse(typeof(State), input);
            Console.WriteLine(state);



            Console.ReadKey();
        }
    }
}
