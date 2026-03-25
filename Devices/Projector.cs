namespace APBD_Cw2_s33681;

public class Projector : Device
{
    public int Luminity { get; set; }
    public String Resolution { get; set; }

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