using System;
using System.Numerics;

namespace WolvenKit.Modkit.RED4.GeneralStructs
{
    public class Converters
    {
        public static float hfconvert(ushort read)// for converting ushort representation of a Half float to a float32
        {
            var sp = Convert.ToUInt16(read & 0x3ff);
            var pow = Convert.ToUInt16((read >> 10) & 0x1f);
            var sign = Convert.ToUInt16(read >> 15);

            var value = 0f;
            if (pow == 0)
            {
                value = Convert.ToSingle(Math.Pow(2, -14)) * (sp / 1024f);
            }
            else if (pow == 31)
            {
                if (sp == 0)
                {
                    value = float.PositiveInfinity;
                }
                else
                {
                    value = float.NaN;
                }
            }
            else
            {
                value = Convert.ToSingle(Math.Pow(2, pow - 15)) * (1 + (sp / 1024f));
            }

            if (sign == 1)
            {
                value = (-1) * value;
            }

            return value;
        }
        public static ushort converthf(float value) // a floating point to halffloat uint16 equivalent representation -65504 <= value <= 65504
        {
            ushort sign = 0;
            ushort sp = 0;
            ushort pow = 0;
            if (float.IsNegative(value) && !float.IsNaN(value))
            {
                sign = 32768;
                value = -1 * value;
            }
            if (value > 65504)
            {
                value = 65504;      // if number provided is > Half.Max or < Half.Min then normalized
            }
            if (value is >= 0 and <= ((float)0.000060975552))
            {
                pow = 0;
                sp = Convert.ToUInt16(value * 1024 * Math.Pow(2, 14));
            }
            else if (float.IsNaN(value) || float.IsPositiveInfinity(value))
            {
                sp = 0;
                pow = 31744;
                if (float.IsNaN(value))
                {
                    sp = 55; // sp can be anything in this case i randomly put 55
                }
            }
            else if (value is >= ((float)0.00006103515625) and <= 65504)
            {
                short temp1 = 14;
                var temp2 = Convert.ToUInt64(((value * Math.Pow(2, temp1)) - 1) * 1024);
                for (; temp2 > 1023; temp1--)
                {
                    temp2 = Convert.ToUInt64(((value * Math.Pow(2, temp1 - 1)) - 1) * 1024);
                }
                sp = Convert.ToUInt16(temp2);
                var temp3 = Convert.ToUInt16((-1 * temp1) + 15);
                pow = Convert.ToUInt16(temp3 << 10);
            }
            var U16 = Convert.ToUInt16(sign | sp | pow);
            return U16;
        }
        public static Vector4 TenBitShifted(uint U32)
        {
            var X = Convert.ToSingle(U32 & 0x3ff);
            var Y = Convert.ToSingle((U32 >> 10) & 0x3ff);
            var Z = Convert.ToSingle((U32 >> 20) & 0x3ff);
            var W = Convert.ToSingle((U32) >> 30);
            var dequant = 1f / 1023f;
            X = (X * 2 * dequant) - 1f;
            Y = (Y * 2 * dequant) - 1f;
            Z = (Z * 2 * dequant) - 1f;
            W /= 3f;
            return new Vector4(X, Y, Z, W);
        }
        public static TargetVec4 TenBitUnsigned(uint U32)
        {
            var X = Convert.ToSingle(U32 & 0x3ff);
            var Y = Convert.ToSingle((U32 >> 10) & 0x3ff);
            var Z = Convert.ToSingle((U32 >> 20) & 0x3ff);
            var W = Convert.ToSingle((U32) >> 30);

            return new TargetVec4(X / 1023f, Y / 1023f, Z / 1023f, W / 3f);
        }

        public static Vector4 TenBitsigned(uint U32)
        {
            var X = Convert.ToInt16(U32 & 0x3ff);
            var Y = Convert.ToInt16((U32 >> 10) & 0x3ff);
            var Z = Convert.ToInt16((U32 >> 20) & 0x3ff);
            var W = Convert.ToByte((U32) >> 30);

            if (X > 511)
            {
                X = (short)(-1 * (X - 512));
            }

            if (Y > 511)
            {
                Y = (short)(-1 * (Y - 512));
            }

            if (Z > 511)
            {
                Z = (short)(-1 * (Z - 512));
            }

            return new Vector4(X / 512f, Y / 512f, Z / 512f, W / 3f);
        }
        public static uint Vec4ToU32(Vector4 v) // reversing for 10bit nors and tans
        {
            v.X = Math.Clamp(v.X, -1f, 1f);
            v.Y = Math.Clamp(v.Y, -1f, 1f);
            v.Z = Math.Clamp(v.Z, -1f, 1f);
            var quant = 1023f;
            var a = Convert.ToUInt32((v.X + 1f) * quant * 0.5f);
            a = Math.Clamp(a, 0, 1023);
            var b = Convert.ToUInt32((v.Y + 1f) * quant * 0.5f);
            b = Math.Clamp(b, 0, 1023);
            b <<= 10;
            var c = Convert.ToUInt32((v.Z + 1f) * quant * 0.5f);
            c = Math.Clamp(c, 0, 1023);
            c <<= 20;
            uint d = 0; // for tangents in bits its 00000000000000000000000000000000
            if (v.W == 0)
            {
                d = 1073741824;  // for normals in bits its 01000000000000000000000000000000
            }

            var U32 = a | b | c | d;
            return U32;
        }

        public static uint Vec3ToU32(TargetVec3 v, ushort w = 1)
        {
            var x = (ushort)(v.X * 1023f);
            var y = (ushort)(v.Y * 1023f);
            var z = (ushort)(v.Z * 1023f);

            var output = (w << 30)
                | (z << 20)
                | (y << 10)
                | x;

            return (uint)output;
        }
    }
    public class Manipulators
    {
        public static float CalculateRealPart(Quaternion Q)
        {
            float w;
            if (((Q.X * Q.X) + (Q.Y * Q.Y) + (Q.Z * Q.Z)) >= 1f)
            {
                w = (float)Math.Sqrt((Q.X * Q.X) + (Q.Y * Q.Y) + (Q.Z * Q.Z) - 1f);
            }
            else
            {
                w = (float)Math.Sqrt(1f - ((Q.X * Q.X) + (Q.Y * Q.Y) + (Q.Z * Q.Z)));
            }

            return w;
        }
    }
}
