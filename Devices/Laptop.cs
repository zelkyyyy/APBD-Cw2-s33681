namespace APBD_Cw2_s33681;

public class Laptop : Device
{
    public string Processor { get;  }
    public int Ram { get;  }
    public Laptop(string Processor, int Ram) : base("Laptop")
    {
        this.Processor = Processor;
        this.Ram = Ram;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Specyfikacja: Procesor={this.Processor} Ram={this.Ram}";
    }
}