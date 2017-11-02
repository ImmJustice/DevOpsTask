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
    public class PlayerCharacterTests
    {
        

       

        [TestMethod()]
        public void GetSpecialAttackResultTest()
        {
            try
            {
                PlayerCharacter vTest = new PlayerCharacter(NormalAttack, SpecialAttack);
                vTest.GetSpecialAttackResult();
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }


        [TestMethod()]
        public void TakeDamageTest()
        {
            try
            {
                PlayerCharacter vTest = new PlayerCharacter(NormalAttack, SpecialAttack);
                vTest.dealDamage(40);
                Assert.AreEqual(40, vDamage);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TakeDamageTest1()
        {
            try
            {
                PlayerCharacter vTest = new PlayerCharacter(NormalAttack, SpecialAttack);
                vTest.TakeDamage(40);
                Assert.AreEqual(40, vDamage);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
    }
}