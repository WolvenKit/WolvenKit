using System.Numerics;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

internal class DirectXMeshHelper
{
    public static Vector4 MultiplyAdd(Vector4 value1, Vector4 value2, Vector4 value3) => (value1 * value2) + value3;
}
