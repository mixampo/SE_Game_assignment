using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{

    enum actions
    {
        NoAction,
        MoveUp,
        MoveRight,
        MoveDown,
        MoveLeft,
        PerformAction
    }

    public class Player
    {
        //Fields
        private decimal playerXPosition;
        private decimal playerYPosition;
        private int playerHitPoints;
        private bool powerUp = true;

        //Properties
        public decimal PlayerXPosition
        {
            get { return playerXPosition; }
            set { playerXPosition = value; }
        }

        public decimal PlayerYPosition
        {
            get { return playerYPosition; }
            set { playerYPosition = value; }
        }

        public int PlayerHitPoints
        {
            get { return playerHitPoints; }
            set { playerHitPoints = value; }
        }

        public bool PowerUp
        {
            get { return powerUp; }
            set { powerUp = value; }
        }




        //Constructors
        public Player(decimal XCoordinate, decimal YCoordinate, bool powerUp, int hitPoints)
        {

        }


        //Methods
        public void update()
        {

        }   

        public void draw(Graphics map)
        {

        }

        public void performInteraction(int keyCode)
        {

        }
    }
}
