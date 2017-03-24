using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{
    public class Enemy: Character
    {
        //Fields
        private List<int> amountOfEnemies = new List<int>();

        //Properties
        public List<int> AmountOfEnemies
        {
           get { return amountOfEnemies; }
           set { amountOfEnemies = value; }
        }
        
 

        //Constructors
        public Enemy(decimal enemyXPosition, decimal enemyYPosition, int enemyHitpoints, int amountOfEnemies)
        {

        }

        //Methods
        public void attackPlayer(Player player)
        {

        }
    }
}
