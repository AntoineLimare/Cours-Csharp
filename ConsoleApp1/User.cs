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
        Console.WriteLine($"Id : {User.Id}");
        Console.WriteLine($"Prénom : {User.FirstName}");
        Console.WriteLine($"Nom : {User.LastName}");
        Console.WriteLine($"Age : {User.Age}");
        Console.WriteLine($"Salaire : {User.Salaire}");
        Console.WriteLine($"Taxe : {User.Taxe}");
    }
}