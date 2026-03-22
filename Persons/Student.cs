namespace APBD_Cw2_s33681.Users;

public class Student : Person
{
    public string Indeks { get; }
    public int Semestr  { get; set; }

    public Student(string firstName, string lastName, string indeks, int semestr) : base(firstName, lastName)
    {
        this.Indeks = indeks;
        this.Semestr = semestr;
    }
}