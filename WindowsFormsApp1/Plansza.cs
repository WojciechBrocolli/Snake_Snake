using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Plansza
    {
        int punkty;
        Point aplce;
        
        Timer timer;
       
        
        public Size size { get; }
  

        public Plansza(Size s)
        {
           
            size = s;
            List<Point> tmp = new List<Point>();
            tmp.Add(new Point(size.Width / 2, size.Height / 2));
        }
    }
    class Snake
    {
        public List<Point> segments;
        public Snake(List<Point>Startposition)
        {
            segments = Startposition;
        }
    }
}
