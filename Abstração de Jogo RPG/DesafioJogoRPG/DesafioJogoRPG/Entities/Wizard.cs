using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJogoRPG.Entities
{
    class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + " Lançou a Magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia com força fraca com bonus de" + Bonus;
            }        
        }
        public void SetHPMPWizard()
        {
            HP = 600;
            MP = 482;
        }
    }
}
