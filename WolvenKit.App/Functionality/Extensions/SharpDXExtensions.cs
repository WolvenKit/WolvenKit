using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Extensions
{
    public static class SharpDXExtensions
    {
        public static SharpDX.Vector2 ToVector2(this System.Numerics.Vector2 v)
        {
            return new SharpDX.Vector2(v.X, v.Y);
        }

        public static SharpDX.Vector3 ToVector3(this System.Numerics.Vector3 v)
        {
            return new SharpDX.Vector3(v.X, v.Y, v.Z);
        }

        public static SharpDX.Vector3 ToVector3(this System.Numerics.Vector4 v)
        {
            return new SharpDX.Vector3(v.X / v.W, v.Y / v.W, v.Z / v.W);
        }
    }
}
