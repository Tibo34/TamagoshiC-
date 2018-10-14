using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagoshi.Util;

namespace Tamagoshi.tamagoshi
{  
        class Tamagoshis
        {

            private String name;
            private int age;
            private int energy;
            private int maxEnergy;
            private static int lifetime = 10;
            private Random rand;

            public Tamagoshis(String name)
            {
                this.name = name;
                this.age = 0;
                this.rand = new Random();
                this.energy = rand.Next(3, 7);
                this.maxEnergy = rand.Next(5, 9);
            }

            public Boolean parle()
            {
                if (energy > 4)
                {
                    Console.WriteLine(name + " est hereux ");
                    return true;
                }
                else
                {
                    Console.WriteLine(name + " est affamé");
                    return false;
                }
            }

            public Boolean parle(int n)
            {
                if (energy > 4)
                {
                    Console.WriteLine(name + " est hereux "+n);
                    return true;
                }
                else
                {
                    Console.WriteLine(name + " est affamé "+n);
                    return false;
                }
            }

        public int getAge()
        {
            return age;
        }

        public String getName()
        {
            return name;
        }

        public Boolean mange()
            {
                if (energy < maxEnergy)
                {
                    energy += rand.Next(1, 3);
                    if (energy > maxEnergy)
                    {
                        energy = maxEnergy;
                    }
                    Console.WriteLine(name + " est content il a bien mangé");
                    return true;
                }
                else
                {
                    Console.WriteLine(name + " n'a pas faim!");
                    return false;
                }
            }

            public Boolean consommeEnergie()
            {
                energy--;
                if (energy <= 0)
                {
                    Console.WriteLine(name + " est KO !");
                    return false;
                }
                return true;
            }

            public String toString()
            {
                return "nom du tamagoshi: " + this.name + " age : " + this.age + " energie :" + energy + " energie max :  " + maxEnergy;
            }

            public int getEnergy()
            {
                return energy;
            }

           
        }
    
 }

