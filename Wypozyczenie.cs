using System.Runtime.InteropServices.JavaScript;
using APBD_Cw2_s33681.Users;

namespace APBD_Cw2_s33681;

public class Wypozyczenie
{
    public Device Co { get; set; }
    public Person Kto { get; set; }
    public DateTime Kiedy { get; set; }
    public DateTime? Zwrot { get; set; }
    public bool? WTerminie { get; set; }
    public DateTime Due { get; set; }

    public Wypozyczenie(Device co, Person kto)
    {
        this.Co = co;
        this.Kto = kto;
        this.Kiedy = DateTime.Now;
        this.Zwrot = null;
        this.WTerminie = null;
        this.Due = Kiedy.AddDays(30);
    }

    public override string ToString()
    {
        return $"Wypożyczenie:\n\tKto: {Kto},\n\tCo: {Co},\n\tKiedy: {Kiedy},\n\tZwrot: {Zwrot},\n\tCzy w terminie: {(WTerminie==true?"Tak":"Nie")}";
    }
}