using WolvenKit.RED4.Types;

namespace WolvenKit.App.Functionality.Extensions
{
    public static class SharpDXExtensions
    {
        public static SharpDX.Vector2 ToVector2(this System.Numerics.Vector2 v) => new(v.X, v.Y);

        public static SharpDX.Vector3 ToVector3(this System.Numerics.Vector3 v) => new(v.X, v.Y, v.Z);

        public static SharpDX.Vector3 ToVector3(this System.Numerics.Vector4 v) => new(v.X / v.W, v.Y / v.W, v.Z / v.W);

        // RedTypes

        public static SharpDX.Vector3 ToVector3(this Vector3 v) => new(v.X, v.Z, -v.Y);

        public static SharpDX.Vector3 ScaleToVector3(this Vector3 v) => new(v.X, v.Z, v.Y);
    }
}
