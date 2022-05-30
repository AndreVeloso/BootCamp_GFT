using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJogoRPG.Entities
{
    class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string ToString()
        {
            return this.Name + " Lançou uma magia das trevas";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return this.Name + " Lançou uma magia das trevas super forte " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia das trevas fraca com bonus de" + Bonus;
            }
        }
        public void SetHPBlackWizard()
        {
            HP = 385;
            MP = 641;
        }
    }
}
