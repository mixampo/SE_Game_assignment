using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_GameAssignment
{
    class Enemy
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

        //Methods
        public void attackPlayer(Player player)
        {

        }
    }
}
