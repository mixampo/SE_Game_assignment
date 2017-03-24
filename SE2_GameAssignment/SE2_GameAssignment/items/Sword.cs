using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment.Items
{
    public class Sword: Item, ICarryable
    {
        public int weight
        {
            get { return 6; }
        }

        //Constructor
        public Sword(Graphics map)
        {
            Draw(map);
        }
    }
}
