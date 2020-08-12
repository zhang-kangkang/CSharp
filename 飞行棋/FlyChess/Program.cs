using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyChess
{
    class Program
    {
        static int player1 = 0;
        static string name1;
        static int player2 = 0;
        static string name2;
        static int currentPlayer = 0;
        static int[] maps = new int[100];   


        static void Main(string[] args)
        {
            ShowHead();
            Console.WriteLine(maps[1]);
            InitMap();
            ShowMap();


            Console.ReadKey();
        }

        static void ShowHead()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************"); 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********飞行棋*********");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************");
        }

        static void Roll()
        {

        }

        static void InputName()
        {

        }

        static void InitMap()
        {
            //0方块，1幸运轮盘，2地雷，3暂停,4传送门
            int[] luckyTurn = { 3, 26, 77 };
            int[] landMine = { 13, 16, 87 };
            int[] pause = { 44, 54, 94 };
            int[] portDoor = { 6, 36, 66 };
            SetInitMapValue(luckyTurn,1);
            SetInitMapValue(landMine, 2);
            SetInitMapValue(pause, 3);
            SetInitMapValue(portDoor, 4);
        }

        static void SetInitMapValue(int[] args,int sign)
        {
            for(int i = 0; i < args.Length; i++)
            {
                maps[args[i]] = sign;
            }
        }

        static void ShowMap()
        {
            for (int i = 0; i < maps.Length; i++)
            {
                if(i == player1 && i == player2)
                {
                    Console.Write("<>");
                    continue;
                }else if(i == player1)
                {
                    Console.Write("A");
                    continue;
                }
                else if (i == player2)
                {
                    Console.Write("B");
                    continue;
                }
                switch (maps[i])
                {
                    case 0:
                        Console.Write("0");
                        continue;
                    case 1:
                        Console.Write("1");
                        continue;
                    case 2:
                        Console.Write("2");
                        continue;
                    case 3:
                        Console.Write("3");
                        continue;
                    case 4:
                        Console.Write("4");
                        continue;
                }
            }
        }

        static void showWinner()
        {

        }
    }
}
