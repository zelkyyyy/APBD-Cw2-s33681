using System.Runtime.InteropServices.JavaScript;
using APBD_Cw2_s33681.Users;

namespace APBD_Cw2_s33681;

public class Wypozyczenie
{
    public Device Co { get; set; }
    public Person Kto { get; set; }
    public DateTime Kiedy { get; set; }
    public int NaIleDni { get; set; }
    public bool WTerminie { get; set; }

    public Wypozyczenie(Device co, Person kto, DateTime kiedy, int naIleDni, bool wTerminie)
    {
        this.Co = co;
        this.Kto = kto;
        this.Kiedy = kiedy;
        this.NaIleDni = naIleDni;
        this.WTerminie = wTerminie;
    }
}