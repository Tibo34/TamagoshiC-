using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using Tamagoshi.tamagoshi;
using Tamagoshi.Util;

namespace Tamagoshi.jeu
{
    class TamaGame
    {
        private ArrayList listDepart;
        private ArrayList listInLife;

        public TamaGame()
        {
            this.listInLife = new ArrayList();
            this.listDepart = new ArrayList();
            initialisation();
        }

        public TamaGame(String[] name)
        {
            this.listInLife = new ArrayList();
            this.listDepart = new ArrayList();
            initialisation(name);
        }

        

        private void Addlist(String name)
        {
            Tamagoshis tam = new Tamagoshis(name);
            listDepart.Add(tam);
            listInLife.Add(tam);
            
        }

        private void initialisation(String[] name)
        {
            foreach(String n in name)
            {
                Addlist(n);
            }
        }

        private void initialisation()
        {
            String str = "";
            while (!str.Equals("Fin"))
            {
                Utilisateur.afficheEcran("Saisir un nom pour le Tamagoshi : ");
                str = Utilisateur.saisirClavier();
                if (!str.Equals("Fin"))
                {
                    Addlist(str);
                }

            }
        }

        public void play()
        {
            int choix = 0;
            while (!isEnd())
            {
                parleAll(listInLife);
                Utilisateur.afficheEcran("Qui voulez-vous nourrir?");
                choix = PlayerChoice();
                Tamagoshis tam =(Tamagoshis) listInLife[choix];
                tam.mange();
                consommeEnergieAll(listInLife);
            }
        }

        private int PlayerChoice() {

            int choix = -1;
            String str = "";
            while (choix < 0)
            {
                str = Utilisateur.saisirClavier();
                try
                {
                    choix = int.Parse(str);
                }
                catch (FormatException)
                {
                    choix = -1;
                    Utilisateur.afficheEcran("ce n'est pas un nombre !!!");
                }
                if (choix > listInLife.Count) {
                    choix = -1;
                    Utilisateur.afficheEcran("Ce tamagoshi n'existe pas !!");                    
                }
            }
            return choix;
        }

        private void parleAll(ArrayList tam)
        {
            int i = 0;
            foreach(Tamagoshis t in tam)
            {
                t.parle(i);
                i++;
               
            }
        }

        private void consommeEnergieAll(ArrayList tam)
        {
            ArrayList remove = new ArrayList();
            foreach(Tamagoshis t in tam)
            {
                t.consommeEnergie();
                if (t.getEnergy()<=0) {
                    remove.Add(t);
                }
            }          
            tam.Remove(remove);
            
        }

        public Boolean isEnd()
        {
            return listInLife.Count<=0;
             
        }


    }
}
