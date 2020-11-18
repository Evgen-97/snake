using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    

  
        class Program
    {
     
     
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            point p1 = new point(5, 5, '*');
            p1.drow();

            point p2 = new point(4, 5, '#');
            p2.drow();

            horizontLine Hline1 = new horizontLine(0, 119, 1, '*');
            horizontLine Hline2 = new horizontLine(0, 119, 29, '*');
            Hline1.Drow();
            Hline2.Drow();

            verticaline Vline1 = new verticaline(0, 0, 28, '*');
            verticaline Vline2 = new verticaline(119, 0, 28, '*');
            Vline1.Drow();
            Vline2.Drow();

            //snake Snake = new snake(p1, 5, direct.ringht);
            //Snake.Drow();
            //Snake.move();
            //Thread.Sleep(400);            Snake.move();
            //Thread.Sleep(400);            Snake.move();
            //Thread.Sleep(400);            Snake.move();
            //Thread.Sleep(400);            Snake.move();
            //Thread.Sleep(400);            Snake.move();
            //Thread.Sleep(400);

            Console.ReadKey();
        }
   
    }
}
