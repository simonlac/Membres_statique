using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classe_statique
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancier un premier objet
            // et initialiser la variable d'instance numero
            Membres_statiques c_stat1 = new Membres_statiques();
            c_stat1.numero = 10;
            // Incrémenter la variable de classe nb_insances
            Membres_statiques.nb_instances += 1;
            // Instancier un deuxième objet
            // et initialiser la variable d'instance numero
            Membres_statiques c_stat2 = new Membres_statiques();
            c_stat2.numero = 20;
            // Incrémenter la variable de classe nb_insances
            Membres_statiques.nb_instances += 1;
            Console.Write("L'attribut statique nb_instances est égal à : "+Membres_statiques.nb_instances);
            Membres_statiques.Afficher();
            // Instancier un nouvel objet puis appeler la méthode statique Incrementer()
            Membres_statiques c_stat3 = new Membres_statiques();
            Membres_statiques.Incrementer();
            Console.ReadKey();
            
        }
    }
}
