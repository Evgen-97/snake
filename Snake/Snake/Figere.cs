using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figere
    {
       protected List<point> plist;
        public void Drow()
        {
            foreach (point p in plist)
            {
                p.drow();
            }
        }
    }
}
