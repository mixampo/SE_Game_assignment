using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{
    public abstract class Item
    {
        //Fields
        private Point position;
        private Graphics map;

        //Properties
        public Point Position
        {
            get { return position; }
        }

        public Graphics Map
        {
            get { return map; }
        }


       

        //Methods
        public void Draw(Graphics map)
        {
            Pen pen = new Pen(Color.Blue);
            pen.Width = 1;

            map.DrawEllipse(pen, position.X, position.Y, 30, 30);
        }
    }
}
