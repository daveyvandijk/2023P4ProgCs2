using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classes01
{
    internal class Skill
    {
        public int damage;
        public int energyCost;
        public string name;


        internal void UseOn(ConsoleMon target,ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
    
}
