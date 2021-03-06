﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
                string vPlayerCharacter = vTest.ChooseClass("Mage");
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }


        [TestMethod()]
        public void NormalAttackTest()
        {
            try
            {
                GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
                vTest.NormalAttack();
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SpecialAttackTest()
        {
            try
            {
                GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
                vTest.SpecialAttack();
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [TestMethod()]
        public void StartBattleTest()
        {
            try
            {

            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
    }
}