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
            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.chr = '*';
            p1.drow();

            point p2 = new point();
            p2.x = 5;
            p2.y = 6;
            p2.chr = '#';
            p2.drow();

            Console.ReadKey();
        }
       
       
    }
}
