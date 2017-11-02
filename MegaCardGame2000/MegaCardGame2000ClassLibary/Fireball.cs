using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000ClassLibary
{
   public class Fireball : SpecialAttack
    {
       

        public int GetAttackResult()
        {
            Random rnd = new Random();

            switch (rnd.Next(0, 2))
            {
                case (1):
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
