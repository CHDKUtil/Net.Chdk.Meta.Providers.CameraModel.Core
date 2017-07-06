using Net.Chdk.Meta.Model.CameraList;
using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.CameraModel
{
    public interface ICameraListProvider
    {
        IDictionary<string, ListPlatformData> GetCameraList(Stream stream);
    }
}
