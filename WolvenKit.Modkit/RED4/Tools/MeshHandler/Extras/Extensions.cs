using System;
using System.Numerics;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

// https://github.com/vpenades/SharpGLTF/blob/master/src/Shared/_Extensions.cs
internal static class Extensions
{
    private const float s_unitLengthThresholdVec3 = 0.00674f;

    internal static bool _IsFinite(this float value) => !(float.IsNaN(value) || float.IsInfinity(value));

    internal static bool _IsFinite(this Vector3 v) => v.X._IsFinite() && v.Y._IsFinite() && v.Z._IsFinite();

    internal static bool IsNormalized(this Vector3 normal)
    {
        if (!normal._IsFinite())
        {
            return false;
        }

        return Math.Abs(normal.Length() - 1) <= s_unitLengthThresholdVec3;
    }

    internal static bool IsValidTangent(this Vector4 tangent)
    {
        if (tangent.W != 1 && tangent.W != -1)
        {
            return false;
        }

        return new Vector3(tangent.X, tangent.Y, tangent.Z).IsNormalized();
    }

    internal static Vector3 SanitizeNormal(this Vector3 normal)
    {
        if (normal == Vector3.Zero)
        {
            return Vector3.UnitX;
        }

        return normal.IsNormalized() ? normal : Vector3.Normalize(normal);
    }

    internal static Vector4 SanitizeTangent(this Vector4 tangent)
    {
        var n = new Vector3(tangent.X, tangent.Y, tangent.Z).SanitizeNormal();
        var s = float.IsNaN(tangent.W) ? 1 : tangent.W;
        return new Vector4(n, s > 0 ? 1 : -1);
    }

    internal static Vector4 YUp(this Vector4 vector) => vector with { Y = vector.Z, Z = -vector.Y };
}
