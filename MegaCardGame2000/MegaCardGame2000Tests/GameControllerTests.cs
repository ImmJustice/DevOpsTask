using Microsoft.VisualStudio.TestTools.UnitTesting;
using MegaCardGame2000ClassLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000ClassLibary.Tests
{
    [TestClass()]
    public class GameControllerTests
    {
        [TestMethod()]
        public void ChooseClassTest()
        {
            try
            {
                GameController GC = new GameController();
                GC.ChooseClass("Warrior");
                Assert.Fail();
            }
            catch (Exception)
            {

                
            }
        }

        
    }
}