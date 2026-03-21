namespace APBD_Cw2_s33681.Users;

public class Person
{
    private static int _idCounter = 0;
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        Id = _idCounter++;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}