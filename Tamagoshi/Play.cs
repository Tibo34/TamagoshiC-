using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagoshi.jeu;

namespace Tamagoshi
{
    class Play
    {
        public static void Main(String[] args)
        {
            String []names= { "Roro", "Zizi", "Riri", "Fifi" };
            TamaGame game = new TamaGame(names,5);
            game.play();
        }
    }
}
