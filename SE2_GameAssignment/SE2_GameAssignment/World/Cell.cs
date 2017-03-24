using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SE2_GameAssignment
{

    public enum cellTypes
    {
        Normal,
        Wall,
        Goal
    }


    public class Cell
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


        //Constructors
        public Cell(Point index, decimal cellXPosition, decimal cellYPosition, cellTypes cellType)
        {

        }


        //Methods
        public void drawCell(Graphics map)
        {

        }
    }
}
