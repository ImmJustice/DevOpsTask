using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000ClassLibary
{
   public  class Character
    {
        public int baseDamage;
        public int currentHealthPoints;
        public int maxHealthPoints;

        public Character(int Damage, int Health)
        {
            baseDamage = Damage;
            currentHealthPoints = Health;
            maxHealthPoints = currentHealthPoints;
        }

        public int TakeDamage(int damage)
        {
            currentHealthPoints -= damage;
            return currentHealthPoints;
        }
    }
}
