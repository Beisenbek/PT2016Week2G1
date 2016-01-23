using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }

        static void F2()
        {
            bool ok = true;

            while (ok)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("right");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("down");
                        break;
                    case ConsoleKey.Escape:
                        ok = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
        static void F1()
        {

            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("left");
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("right");
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("up");
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("down");
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
