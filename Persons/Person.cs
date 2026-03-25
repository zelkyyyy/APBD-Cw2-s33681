namespace APBD_Cw2_s33681.Users;

public abstract class Person
{
    private static int _idCounter = 1;
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int WypozyczeniaLimit { get;  }
    public double Kara { get; private set; }

    public Person(string firstName, string lastName,  int wypozyczeniaCount)
    {
        this.Id = _idCounter++;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WypozyczeniaLimit = wypozyczeniaCount;
        this.Kara = 0;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} Limit: {this.WypozyczeniaLimit} Kara: {this.Kara}";
    }

    public void AddPenalty(double penaly)
    {
        Kara += penaly;
    }

    public void PayPenalty(double penalty)
    {
        Kara -= penalty;
    }
}