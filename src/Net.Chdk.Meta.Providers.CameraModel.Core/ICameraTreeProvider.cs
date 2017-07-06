﻿using Net.Chdk.Meta.Model.CameraTree;
using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.CameraModel
{
    public interface ICameraTreeProvider
    {
        IDictionary<string, TreePlatformData> GetCameraTree(Stream stream);
    }
}
