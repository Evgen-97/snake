using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char chr = '*';
            print(x1, y1, chr);
            Console.ReadKey();
        }
        static void print(int x, int y, char chr)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(chr);
        }
       
    }
}
