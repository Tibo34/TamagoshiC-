using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagoshi.Util
{
    class Utilisateur
    {
        public static String saisirClavier()
        {
            return Console.ReadLine();
        }

        public static void afficheEcran(String mess)
        {
            Console.WriteLine(mess);
        }
    }
}
