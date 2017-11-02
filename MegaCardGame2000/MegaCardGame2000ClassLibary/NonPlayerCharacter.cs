using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000ClassLibary
{
   public class NonPlayerCharacter : Character
    {
        public NormalAttack attack;
        public char enemyType;

        public int GetNormalAttackResult()
        {
            return baseDamage;
        }
    }
}
