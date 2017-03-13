using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_GameAssignment
{
    public class Enemy
    {
        //Fields
        private decimal enemyXPosition;
        private decimal enemyYPosition;
        private int enemyHitPoints;

        //Properties
        public decimal EnemyXPosition
        {
            get { return enemyXPosition; }
            set { enemyXPosition = value; }
        }

        public decimal EnemyYPosition
        {
            get { return enemyYPosition; }
            set { enemyYPosition = value; }
        }

        public int EnemyHitPoints
        {
            get { return enemyHitPoints; }
            set { enemyHitPoints = value; }
        }


        //Constructors
        public Enemy(decimal enemyXPosition, decimal enemyYPosition, int enemyHitpoints)
        {

        }

        //Methods
        public void update()
        {

        }
        
        public void attackPlayer(Player player)
        {

        }

        public void draw(Graphics map)
        {

        }
    }
}
