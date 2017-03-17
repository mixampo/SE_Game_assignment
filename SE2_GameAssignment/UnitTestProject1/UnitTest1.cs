using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE2_GameAssignment;
    

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void addNewPlayerTest()
        {
            Player testPlayer1 = new Player(50, 50, true, 3);
            Assert.AreEqual(3, testPlayer1.PlayerHitPoints, "The player appears to have too many hitpoints");
        }
    }
}
