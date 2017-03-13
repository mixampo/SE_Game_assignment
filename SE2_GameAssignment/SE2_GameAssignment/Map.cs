using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{
    public class Map
    {
        //Fields
        private Size mapSize;
        private Point endPosition;
        private Size cellSize;
        private int amountOfCells;

        //Properties
        public Size CellSize
        {
            get { return cellSize; }
            private set { cellSize = value; }
        }
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


        //Constructors
        public Map(Size mapSize, Size cellSize, int cellCount, Point endPosition)
        {
        
        }
       
            
       
        //Methods
        public void draw(Graphics map)
        {

        }

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

        public Size getCellSize()
        {
            return CellSize;
        }


    }
}
