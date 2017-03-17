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

    public class Player: Character
    {
        //Fields
        private bool powerUp;
        private int playerHitPoints = 3;



        //Properties
        public bool PowerUp
        {
            get { return powerUp; }
            set { powerUp = value; }
        }

        public int PlayerHitPoints
        {
            get { return playerHitPoints; }
            set { playerHitPoints = value; }
        }


        //Constructors
        public Player(decimal XCoordinate, decimal YCoordinate, bool powerUp, int hitPoints)
        {

        }


        //Methods
        public void performInteraction(int keyCode)
        {

        }
    }
}
