using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000ClassLibary
{
    public class GameController
    {
        public NonPlayerCharacter enemy;
        public PlayerCharacter player;

        public void ChooseClass(string Class)
        {
            switch (Class)
            {
                case "M":
                    player = new Mage();
                    player.specialAttack = new Fireball();
                    break;

                case "W":
                    player = new Warrior();
                    player.specialAttack = new Berserk();
                    break;
                case "T":
                    player = new Thief();
                    player.specialAttack = new Back_Stab();
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        public void NormalAttack()
        {
            throw new NotImplementedException();
        }

        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public void StartBattle()
        {
            throw new NotImplementedException();
        }

        
    }
}
