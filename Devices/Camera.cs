namespace APBD_Cw2_s33681;

public class Camera : Device
{
    public int Bitrate { get;  }
    public string Resolution { get;  }


    public Camera(int bitrate, string resolution) : base("Camera")
    {
        this.Bitrate = bitrate;
        this.Resolution = resolution;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Specyfikacja: bitrate={this.Bitrate}, resolution={this.Resolution}";
    }
}