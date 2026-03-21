namespace APBD_Cw2_s33681;

public class Camera : Device
{
    public int Bitrate { get; set; }
    public string Resolution { get; set; }


    public Camera(int bitrate, string resolution) : base("Camera")
    {
        this.Bitrate = bitrate;
        this.Resolution = resolution;
    }
}