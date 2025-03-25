

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Choix 1: Salaire net mensuel");
            Console.Write("Choix 2: tableau");
            int choix = Convert.ToInt32(Console.ReadLine());
            if (choix == 1)
            {
                Fonction.SalaireMensuelNet();
            }
            else if (choix == 2)
            {
                Fonction.TableauSalaire();
            }


        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : Veuillez entrer des valeurs numériques valides.");
        }
        User Leo = new User(1, "Leo", "Lesage", 18, 10, 50);
        Leo.AfficherInfo();
    }
    
}