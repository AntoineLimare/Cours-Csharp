class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Salaire { get; set; }
    public double Taxe { get; set; }

    public User(int id, string firstName, string lastName, int age, double salary, double tax)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salaire = salary;
        Taxe = tax;
    }
    public void AfficherInfo()
    {
        Console.WriteLine($"Id : {Id}");
        Console.WriteLine($"Prénom : {FirstName}");
        Console.WriteLine($"Nom : {LastName}");
        Console.WriteLine($"Age : {Age}");
        Console.WriteLine($"Salaire : {Salaire}");
        Console.WriteLine($"Taxe : {Taxe}");
    }
}