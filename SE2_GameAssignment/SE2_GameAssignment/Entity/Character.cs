using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{
    public abstract class Character
    {
        //Fields
        private decimal characterXPosition;
        private decimal characterYPosition;
        private int characterHitPoints;


        //Properties
        public decimal CharacterXPosition
        {
            get { return characterXPosition; }
            set { characterXPosition = value; }
        }

        public decimal CharacterYPosition
        {
            get { return characterYPosition; }
            set { characterYPosition = value; }
        }

        public int CharacterHitPoints
        {
            get { return characterHitPoints; }
            set { characterHitPoints = value; }
        }

        //Constructors






        
        //Methods
        public void update()
        {

        }

        public void draw(Graphics map)
        {

        }
    
    }
}
