using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagoshi
{
    namespace tamagoshi
    {
        class Tamagoshi
        {

            private String name;
            private int age;
            private int energy;
            private int maxEnergy;
            private static int lifetime = 10;
            private Random rand;

            public Tamagoshi(String name)
            {
                this.name = name;
                this.age = 0;
                this.energy = rand.Next(3, 7);
                this.maxEnergy = rand.Next(5, 9);
            }



        }
    }
   
}
