using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment.Items
{
    public class Boots: Item, ICarryable
    {
        public int weight
        {
            get { return 5; }
        }

        //Constructor
        public Boots(Graphics map)
        {
            Draw(map);
        }
            


    }
}
