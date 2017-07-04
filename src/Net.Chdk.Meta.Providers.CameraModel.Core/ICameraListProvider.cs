using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.CameraModel
{
    public interface ICameraListProvider
    {
        IDictionary<string, IDictionary<string, string>> GetCameraList(Stream stream);
    }
}
