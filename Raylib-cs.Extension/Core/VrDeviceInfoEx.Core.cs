namespace Raylib_cs.Extension;

public static partial class VrDeviceInfoEx
{
    public static VrStereoConfig LoadConfig(this VrDeviceInfo device) => Raylib.LoadVrStereoConfig(device);
}