namespace APBD_Cw2_s33681;

public abstract class Device
{
    private static int _IdCounter = 1;
    public int Id { get;  }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    public Device(string name)
    {
        Id = _IdCounter++;
        this.Name = name;
        this.IsAvailable = true;
    }

    public override string ToString()
    {
        return $"{this.Name} (Dostępność: {this.IsAvailable})";
    }

    public void Unavailable()
    {
        this.IsAvailable = false;
    }

    public void Available()
    {
        this.IsAvailable = true;
    }
}