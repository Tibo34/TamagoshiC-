using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagoshi.tamagoshi
{
    class GrosJoueur : Tamagoshis
    {
        public GrosJoueur(String name): base(name)
        {

        }

        public Boolean consommeFun()
        {
            Boolean r=base.consommeEnergie();
            r = base.consommeEnergie();
            return r;
        }

    }
}
