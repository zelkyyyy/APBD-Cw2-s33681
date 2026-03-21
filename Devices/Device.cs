namespace APBD_Cw2_s33681;

public class Device
{
    private static int _IdCounter = 0;
    public int Id { get;  }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    public Device(string name)
    {
        Id = _IdCounter++;
        this.Name = name;
        this.IsAvailable = true;
    }
}