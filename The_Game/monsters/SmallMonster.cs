using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;

namespace The_Game.monsters
{
    public class SmallMonster : CharacterBase
    {
        public SmallMonster(string name, int level)
            : base(name, level)
        {
            this.GenMonsterStats(level);
            this.Health = 100;
        }

        public override void TakeDamage(int amount, CharacterBase target)
        {
            Health = Health - amount;

            if (Health <= 0)
            {
                OnDeath(target);
            }
        }

        public override void EarnCoins(int amount)
        {
            throw new NotImplementedException();
        }

        public override void OnDeath(CharacterBase target)
        {
            target.GainExperience(50);
            target.EarnCoins(10);
        }
    }
}
