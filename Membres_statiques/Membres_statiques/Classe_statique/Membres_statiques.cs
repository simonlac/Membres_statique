using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_statique
{
    class Membres_statiques
    {
        
        public int numero; // Variable d'instance.
        public static int nb_instances=0; // Variable de classe ou variable statique.
        //Méthode statique
        public static void Afficher()
        {
            Console.WriteLine("\nJe suis une méthode statique.");
        }
        public static void Incrementer()
        {
            nb_instances++;
            Console.WriteLine("Le nombre d'objets instanciés est égal à "+ nb_instances);
        }
    }
}
