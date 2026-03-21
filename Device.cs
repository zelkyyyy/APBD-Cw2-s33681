namespace APBD_Cw2_s33681;

public class Device
{
    private static int IdCounter;
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    public Device(string name)
    {
        Id = IdCounter++;
        this.Name = name;
        this.IsAvailable = true;
    }
}