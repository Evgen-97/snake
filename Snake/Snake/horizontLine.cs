using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class horizontLine : Figere
    {      
        public horizontLine(int x1, int x2, int y, char c)
        {
            plist = new List<point>();
            for (int x = x1; x <= x2;x++)
            {
                point p = new point(x, y, c);
                plist.Add(p);
            }
        }     
    }
    class verticaline : Figere
    {    
       public verticaline (int x, int y1, int y2, char c)
        {
            plist = new List<point>();
            for (int y = y1; y <= y2; y++)
            {
                point p = new point(x, y, c);
                plist.Add(p);
            }
        }    
    }
}
