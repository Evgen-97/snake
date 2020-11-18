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

        public point(int x, int y, char chr)
        {
            this.x = x;
            this.y = y;
            this.chr = chr;
        }
        public point(point p)
        {
            x = p.x;
            y = p.y;
            chr = p.chr;
        }
        public void move(int offer,direct dir)
        {
            switch (dir)
            {
                case direct.up:
                    this.y += offer;
                    break;
                case direct.down:
                    this.y -= offer;
                    break;
                case direct.left:
                    this.x -= offer;
                    break;
                case direct.ringht:
                    this.x += offer;
                    break;
                default:
                    break;
            }
        }

        public void drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(chr);
        }
        public void Clear()
        {
            chr = ' ';
            drow();
        }
    }
}
