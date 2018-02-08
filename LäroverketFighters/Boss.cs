using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LäroverketFighters
{
    class Boss : Enemy
    {
        private int armor = 2, critChance, extraHP;

        public override void TakeDamage(int _damage)
        {
            int actualDamage = _damage - armor;
            hp -= actualDamage;

            Console.WriteLine(actualDamage);

            if (hp < 1)
            {
                isAlive = false;
            }
        }
    }
}
