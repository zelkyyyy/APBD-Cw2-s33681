namespace APBD_Cw2_s33681.Users;

public class Lecturer : Person
{
    public string Tytuł { get; set; }
    public string Katedra { get; set; }
    public string Stanowisko { get; set; }

    public Lecturer(string imie, string nazwisko, string tytuł, string katedra, string stanowisko) : base(imie,
        nazwisko, 5)
    {
        this.Tytuł = tytuł;
        this.Katedra = katedra;
        this.Stanowisko = stanowisko;
    }

    public override string ToString()
    {
        return $"{Katedra} {Tytuł} {base.ToString()}";
    }
}