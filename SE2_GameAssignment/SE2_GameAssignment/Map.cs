using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{
    class Map
    {
        //Fields
        private Size mapSize;
        private Point endPosition;
        private int amountOfCells;

        //Properties
        public Point EndPosition
        {
            get { return endPosition; }
            private set { endPosition = value; }
        }

        public Size MapSize
        {
            get { return mapSize; }
            private set { mapSize = value; }
        }

        public int AmountOfCells
        {
            get { return amountOfCells; }
            private set { amountOfCells = value; }
        }
       
            
       
        //Methods
        public Point getEndPosition()
        {
            return EndPosition;
        }

        public Size getMapSize()
        {
            return MapSize;
        }

        public int getAmountOfCells()
        {
            return AmountOfCells;
        }


    }
}
