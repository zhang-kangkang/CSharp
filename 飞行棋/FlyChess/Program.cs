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
        static int[] maps = new int[100];   //数组初始值是0


        static void Main(string[] args)
        {
            ShowHead();
            Console.WriteLine("");
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
            Console.WriteLine("*************************");
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
            int[] landMine = { 13, 26, 87 };
            int[] pause = { 44, 54, 94 };
            int[] portDoor = { 9, 36, 66 };
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("提示：");
            Console.WriteLine("     □方块，★幸运轮盘，◎地雷，▲暂停,卍传送门");
            Console.WriteLine("     A玩家1位置，B玩家2位置，<>两个玩家都在该位置");
            Console.WriteLine("");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(getMapELement(i));
                if (i == 29)
                {
                    Console.WriteLine("");
                }
            }
            for (int i = 30; i < 35; i++)
            {
                Console.WriteLine("                                                          {0}", getMapELement(i));
            }
            for (int i = 64; i > 34; i--)
            {
                Console.Write(getMapELement(i));
                if (i == 35)
                {
                    Console.WriteLine("");
                }
            }
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine("{0}                                                        ", getMapELement(i));
            }
            for (int i = 70; i < 100; i++)
            {
                Console.Write(getMapELement(i));
                if (i == 99)
                {
                    Console.WriteLine("");
                }
            }
        }

        static string getMapELement(int i){
            // 有玩家位于该位置时
            if (i == player1 || i == player2)
            {
                if (i == player1 && i == player2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "<>";
                }
                else if (i == player1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "A";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    return "B";
                }
            }
            else
            {
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        return "□";
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        return "★";
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        return "◎";
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        return "▲";
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        return "卍";
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        return "□";
                }
            }

        }

        static void GameRound()
        {

        }

        static void showWinner()
        {

        }
    }
}
