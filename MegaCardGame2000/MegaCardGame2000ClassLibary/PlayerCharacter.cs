using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000ClassLibary
{
  public  class PlayerCharacter : Character
    {
        public char characterName;
        public NormalAttack normalAttack;
        public SpecialAttack specialAttack;

        public PlayerCharacter(int Damage, int Hp) : base(Damage, Hp) { }

        public int GetNormalAttackResult()
        {
            return baseDamage;
        }

        public int GetSpecialAttackResult()
        {
            throw new NotImplementedException();
        }
    }
}
