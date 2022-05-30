using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJogoRPG.Entities
{
    class Ninja : Hero
    {      
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + " Lançou as shurikens";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return this.Name + " Lançou uam shuriken dupla " + Bonus;
            }
            else
            {
                return this.Name + " Lançou a shuriken com pouca força" + Bonus;
            }
        }
        public void SetHPMPNinja()
        {
            HP = 385;
            MP = 641;
        }
    }
}
