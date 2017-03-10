using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SE2_GameAssignment
{

    enum cellTypes
    {
        Normal,
        Wall,
        Goal,
    }

    class Cell
    {
        //Fields
        private decimal cellXPosition;
        private decimal cellYPosition;



        //Properties
        public decimal CellXPosition
        {
            get { return cellXPosition; }
            set { cellXPosition = value; }
        }

        public decimal CellYPosition
        {
            get { return cellYPosition; }
            set { cellYPosition = value; }
        }


        //Methods
        public void drawCell(Graphics map)
        {

        }

        public void cell(decimal XCoordinate, decimal YCoordinate)
        {

        }
    }
}
