namespace APBD_Cw2_s33681.Users;

public class Person
{
    private static int _idCounter = 0;
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int WypozyczeniaLimit { get; set; }
    public double Kara { get; set; }

    public Person(string firstName, string lastName,  int wypozyczeniaCount)
    {
        Id = _idCounter++;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WypozyczeniaLimit = wypozyczeniaCount;
        this.Kara = 0;
    }
    
}