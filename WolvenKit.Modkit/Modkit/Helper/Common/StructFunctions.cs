using System;
using System.Numerics;

namespace WolvenKit.RED4.GeneralStructs
{
    public class Converters
    {
        public static float hfconvert(UInt16 read)// for converting ushort representation of a Half float to a float32
        {
            String bin = Convert.ToString(read, 2).PadLeft(16, '0');
            UInt16 sp = Convert.ToUInt16(bin.Substring(6, 10), 2);
            UInt16 pow = Convert.ToUInt16(bin.Substring(1, 5), 2);
            UInt16 sign = Convert.ToUInt16(bin.Substring(0, 1));

            float value = 0f;
            if (pow == 0)
            {
                value = Convert.ToSingle(Math.Pow(2, -14)) * (sp / 1024f);
            }
            else if (pow == 31)
            {
                if (sp == 0)
                    value = float.PositiveInfinity;
                else
                    value = float.NaN;
            }
            else
            {
                value = Convert.ToSingle(Math.Pow(2, pow - 15)) * (1 + sp / 1024f);
            }

            if (sign == 1)
            {
                value = (-1) * value;
            }

            return value;
        }
        public static UInt16 converthf(float value) // a floating point to halffloat uint16 equivalent representation -65504 <= value <= 65504
        {
            UInt16 sign = 0;
            UInt16 sp = 0;
            UInt16 pow = 0;
            if (float.IsNegative(value) && !float.IsNaN(value))
            {
                sign = 32768;
                value = -1 * value;
            }
            if (value > 65504)
            {
                value = 65504;      // if number provided is > Half.Max or < Half.Min then normalized
            }
            if (value >= 0 && value <= (float)0.000060975552)
            {
                pow = 0;
                sp = Convert.ToUInt16(value * 1024 * Math.Pow(2, 14));
            }
            else if (float.IsNaN(value) || float.IsPositiveInfinity(value))
            {
                sp = 0;
                pow = 31744;
                if (float.IsNaN(value))
                    sp = 55; // sp can be anything in this case i randomly put 55
            }
            else if (value >= (float)0.00006103515625 && value <= (float)65504)
            {
                Int16 temp1 = 14;
                UInt64 temp2 = Convert.ToUInt64((value * Math.Pow(2, temp1) - 1) * 1024);
                for (; temp2 > 1023; temp1--)
                {
                    temp2 = Convert.ToUInt64((value * Math.Pow(2, temp1 - 1) - 1) * 1024);
                }
                sp = Convert.ToUInt16(temp2);
                UInt16 temp3 = Convert.ToUInt16((-1 * temp1) + 15);
                pow = Convert.ToUInt16(temp3 << 10);
            }
            UInt16 U16 = Convert.ToUInt16(sign | sp | pow);
            return U16;
        }
        public static Vector4 TenBitShifted(UInt32 U32)
        {
            Int16 X = Convert.ToInt16(U32 & 0x3ff);
            Int16 Y = Convert.ToInt16((U32 >> 10) & 0x3ff);
            Int16 Z = Convert.ToInt16((U32 >> 20) & 0x3ff);
            byte W = Convert.ToByte((U32) >> 30);
            return new Vector4((X - 511) / 512f, (Y - 511) / 512f, (Z - 511) / 512f, W / 3f);
        }
        public static Vector4 TenBitUnsigned(UInt32 U32)
        {
            Int16 X = Convert.ToInt16(U32 & 0x3ff);
            Int16 Y = Convert.ToInt16((U32 >> 10) & 0x3ff);
            Int16 Z = Convert.ToInt16((U32 >> 20) & 0x3ff);
            byte W = Convert.ToByte((U32) >> 30);

            return new Vector4(X / 1023f, Y / 1023f, Z / 1023f, W / 3f);
        }
        public static Vector4 TenBitsigned(UInt32 U32)
        {
            Int16 X = Convert.ToInt16(U32 & 0x3ff);
            Int16 Y = Convert.ToInt16((U32 >> 10) & 0x3ff);
            Int16 Z = Convert.ToInt16((U32 >> 20) & 0x3ff);
            byte W = Convert.ToByte((U32) >> 30);

            if (X > 511)
                X = (Int16)(-1 * (X - 512));
            if (Y > 511)
                Y = (Int16)(-1 * (Y - 512));
            if (Z > 511)
                Z = (Int16)(-1 * (Z - 512));
            return new Vector4(X / 512f, Y / 512f, Z / 512f, W / 3f);
        }
        public static UInt32 Vec4ToU32(Vector4 v) // reversing for 10bit nors and tans
        {
            if (v.X < -0.998046f)
                v.X = -0.998046f;
            if (v.Y < -0.998046f)
                v.Y = -0.998046f;
            if (v.Z < -0.998046f)
                v.Z = -0.998046f;

            UInt32 a = Convert.ToUInt32(v.X * 512 + 511);
            UInt32 b = Convert.ToUInt32(v.Y * 512 + 511) << 10;
            UInt32 c = Convert.ToUInt32(v.Z * 512 + 511) << 20;
            UInt32 d = 0; // for tangents in bits its 00000000000000000000000000000000
            if (v.W == 0)
                d = 1073741824;  // for normals in bits its 01000000000000000000000000000000
            UInt32 U32 = a | b | c | d;
            return U32;
        }
    }
    public class Manipulators
    {
        public static float CalculateRealPart(Quaternion Q)
        {
            float w;
            if ((Q.X * Q.X + Q.Y * Q.Y + Q.Z * Q.Z) >= 1f)
                w = (float)Math.Sqrt((Q.X * Q.X + Q.Y * Q.Y + Q.Z * Q.Z) - 1f);
            else
                w = (float)Math.Sqrt(1f - (Q.X * Q.X + Q.Y * Q.Y + Q.Z * Q.Z));
            return w;
        }
    }
}
