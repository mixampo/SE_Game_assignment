using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment.Items
{
    public class Armor: Item, ICarryable
    {
       public int weight
        {
            get { return 3; }
        }

        //Constructor
        public Armor(Graphics map)
        {
            Draw(map);
        }
    }
}
