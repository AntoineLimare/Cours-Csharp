using System;

class Program
{
    static void Main()
    {
        try
        {
            // Récupération du salaire annuel
            Console.Write("Entrez votre salaire annuel (en euros) : ");
            double salaireAnnuel = Convert.ToDouble(Console.ReadLine());

            // Récupération du taux d'imposition
            Console.Write("Entrez votre taux d'imposition (en pourcentage) : ");
            double tauxImposition = Convert.ToDouble(Console.ReadLine());

            // Calcul du salaire annuel net
            double salaireAnnuelNet = salaireAnnuel * (1 - (tauxImposition / 100));

            // Calcul du salaire mensuel brut et net
            double salaireMensuelBrut = salaireAnnuel / 12;
            double salaireMensuelNet = salaireAnnuelNet / 12;

            // Affichage du résultat
            Console.WriteLine($"Votre salaire net mensuel est de : {salaireMensuelNet:F2} euros");

            // Conseils en fonction du salaire
            if (salaireAnnuel > 50000)
            {
                Console.WriteLine("Conseil : Pensez à faire des dons pour réduire vos impôts !");
            }
            else if (salaireMensuelBrut < 1500)
            {
                Console.WriteLine("C'est un salaire courant pour un alternant, continuez à acquérir de l'expérience !");
            }
            else if (salaireAnnuel >= 30000 && salaireAnnuel <= 40000)
            {
                Console.WriteLine("Pourquoi ne pas venir au CESI pour un bac +5 et booster votre carrière ?");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : Veuillez entrer des valeurs numériques valides.");
        }
    }
}
