using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagoshi.tamagoshi
{
    class GrosMangeur : Tamagoshis
    {
        public GrosMangeur(String name)  :base(name) {          

        }

        public override Boolean consommeEnergie()
        {
            Boolean r=base.consommeEnergie()&&base.consommeEnergie();
            return r;
        }

    }
}
