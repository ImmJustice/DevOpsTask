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
    public class NonPlayerCharacterTests
    {
        [TestMethod()]
        public void TakeDamageTest()
        {
            try
            {
                NonPlayerCharacter vTest = new NonPlayerCharacter(NormalAttack);
                vTest.TakeDamage();
                Assert.AreEqual(10,vDamage);
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
                NonPlayerCharacter vTest = new NonPlayerCharacter(NormalAttack);
                vTest.TakeDamage();
                Assert.AreEqual(40, vDamage);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetNormalAttackResultTest()
        {
            try
            {
                NonPlayerCharacter vTest = new NonPlayerCharacter(NormalAttack);
                vTest.GetNormalAttackResult();

            }
            catch (Exception)
            {

                Assert.Fail();
            }

        }

        [TestMethod()]
        public void NPCAttackTest()
        {
            try
            {
                NonPlayerCharacter vTest = new NonPlayerCharacter(NormalAttack);
                vTest.NPCAttack();
                Assert.AreEqual(10, vNpcAttack);
            }
            catch (Exception)
            {

                Assert.Fail();
            }

        }

    }
}