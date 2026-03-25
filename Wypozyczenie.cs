using APBD_Cw2_s33681.Users;

namespace APBD_Cw2_s33681;

public class Wypozyczenie
{
    public Device Co { get;  }
    public Person Kto { get;  }
    public DateTime Kiedy { get;  }
    public DateTime? Zwrot { get; set; }

    public bool? WTerminie
    {
        get
        {
            if (Zwrot == null) return null;
            return Zwrot <= Due;
        }
    }
    public DateTime Due { get; set; }

    public Wypozyczenie(Device co, Person kto)
    {
        this.Co = co;
        this.Kto = kto;
        this.Kiedy = DateTime.Now;
        this.Zwrot = null;
        this.Due = Kiedy.AddDays(30);
    }

    public void Return(double penaltyRate)
    {
        Co.Available();
        Zwrot = DateTime.Now;
        
        var ile = Zwrot.Value - Due;

        if (ile.TotalDays > 0)
            Kto.AddPenalty(Math.Ceiling(ile.TotalDays) * penaltyRate);
    }
    public override string ToString()
    {
        return $"Wypożyczenie:\n\tKto: {Kto},\n\tCo: {Co},\n\tKiedy: {Kiedy},\n\tZwrot: {Zwrot},\n\tCzy w terminie: {(WTerminie==true||WTerminie==null?"Tak":"Nie")}";
    }

    public void ShortenDueDate(int days)
    {
        Due = DateTime.Now.AddDays(-days);
    }
}