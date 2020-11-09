using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class point
    {
        public int x;
        public int y;
        public char chr;

        //point(int x,int y, char chr)
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.chr = chr;
             

        //}
        public void drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(chr);
        }
    }
}
