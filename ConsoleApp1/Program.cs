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

            // Calcul du salaire mensuel net
            double salaireMensuelNet = salaireAnnuelNet / 12;

            // Affichage du résultat
            Console.WriteLine($"Votre salaire net mensuel est de : {salaireMensuelNet:F2} euros");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : Veuillez entrer des valeurs numériques valides.");
        }
    }
}