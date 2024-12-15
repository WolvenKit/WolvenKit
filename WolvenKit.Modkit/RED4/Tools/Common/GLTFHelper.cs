using System.IO;

namespace WolvenKit.Modkit.RED4.Tools.Common;

public static class GLTFHelper
{
    public static string PrepareFilePath(string filePath, bool asBinary)
    {
        if (Path.GetExtension(filePath) == ".mesh")
        {
            filePath = Path.ChangeExtension(filePath, null);
        }

        return filePath + (asBinary ? ".glb" : ".gltf");
    }
}