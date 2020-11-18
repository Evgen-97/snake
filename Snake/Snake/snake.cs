using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

  
    class snake : Figere
    {
       public direct dir;
        public snake (point Start,int length,direct _dir)
        {
           

            
            dir = _dir;
            plist = new List<point>();
            for(int i = 0;i <= length;i++)
            {
                point p = new point(Start);
                p.move(i, _dir);
                plist.Add(p);
            }
        }
        public void move()
        {
            
            point talk = plist.First();
            plist.Remove(talk);
            point head = getpoint();
            head.drow();
            talk.Clear();
        }
        public point getpoint()
        {
            point head = plist.Last();
            point next = new point(head);
            plist.Add(next);
            next.move(1, dir);
            return next;
        }
        public void hendl (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) dir = direct.left;
            if (key == ConsoleKey.RightArrow) dir = direct.ringht;
            if (key == ConsoleKey.UpArrow) dir = direct.up;
            if (key == ConsoleKey.DownArrow) dir = direct.down;
        }
    }
}
