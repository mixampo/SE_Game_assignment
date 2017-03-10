using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_GameAssignment
{
    class World
    {
        //Fields
        private bool wonGame;

        //Properties
        public bool WonGame
        {
            get { return wonGame; }
            set { wonGame = value; }
        }

        //Methods
        public void updateEverythingInWorld()
        {

        }

        public bool gameWon()
        {
            wonGame = true;
            return WonGame;
        }

        public bool gameLost()
        {
            wonGame = false;
            return WonGame;
        }
    }
}
