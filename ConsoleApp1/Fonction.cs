

class Fonction
{
    public static void SalaireMensuelNet()
    {
        Console.Write("Entrez votre salaire annuel (en euros) : ");
        double salaireAnnuel = Convert.ToDouble(Console.ReadLine());

        // Récupération du taux d'imposition
        Console.Write("Entrez votre taux d'imposition (en pourcentage) : ");
        double tauxImposition = Convert.ToDouble(Console.ReadLine());
        
        double salaireAnnuelNet = salaireAnnuel * (1 - (tauxImposition / 100));

        // Calcul du salaire mensuel brut et net
        double salaireMensuelBrut = salaireAnnuel / 12;
        double salaireMensuelNet = salaireAnnuelNet / 12;
        

        Console.WriteLine($"Votre salaire net mensuel est de : {salaireMensuelNet:F2} euros");
        return salaireMensuelNet
    }// Calcul du salaire annuel net
    
    public static void TableauSalaire(double salaireMensuelNet)
    {
        SalaireMensuelNet();
        // Récupération du taux d'imposition
        Console.Write("Entrez votre prime de noël (en pourcentage) : ");
        double primeNoel = Convert.ToDouble(Console.ReadLine());
        
        
        // Déclaration et initialisation des variables
        string[] mois = {
            "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
            "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"
        };


        // Affichage du tableau structuré
        Console.WriteLine("+------------+---------+");
        Console.WriteLine("| Mois       | Salaire |");
        Console.WriteLine("+------------+---------+");

        foreach (string m in mois)
        {
            if (m == "Décembre")
            {

                Console.WriteLine($"| {m,-10} | {salaireMensuelNet * (1 + primeNoel / 100):F2} |");
            }

            else if (m == "Août")
            {
                Console.WriteLine($"| {m,-10} | {0:F2} |");
            }

            else
            {
                // Salaire fixe pour tous les mois
                Console.WriteLine($"| {m,-10} | {salaireMensuelNet:F2} |");
            }
        }

        Console.WriteLine("+------------+---------+");
    }

}



}