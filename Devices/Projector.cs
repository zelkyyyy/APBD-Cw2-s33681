namespace APBD_Cw2_s33681;

public class Projector : Device
{
    public int Luminity { get;  }
    public string Resolution { get;  }

    public Projector(int luminity, String resolution) : base("Projector")
    {
        this.Luminity = luminity;
        this.Resolution = resolution;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Specyfikacja: Jasność={this.Luminity} Resolution={this.Resolution}";
    }
}