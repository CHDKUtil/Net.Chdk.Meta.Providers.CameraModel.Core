using Net.Chdk.Meta.Model.CameraModel;
using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.CameraModel
{
    public interface ICameraTreeProvider
    {
        IDictionary<string, IDictionary<string, TreeRevisionData>> GetCameraTree(Stream stream);
    }
}
