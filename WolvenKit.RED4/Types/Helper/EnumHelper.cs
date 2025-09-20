using System.Globalization;
using System.Numerics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public class EnumHelper
{
    public static bool IsBitfield(Type enumType) => enumType.GetCustomAttribute<FlagsAttribute>() != null;

    public static string RedIntToEnumString(Type enumType, IRedInteger redInteger) => Enum.GetName(enumType, RedIntToULong(redInteger)) ?? redInteger.ToString(CultureInfo.CurrentCulture);

    // Needs the current IRedInteger object to infer its type
    public static IRedInteger EnumStringToRedInt(Type enumType, string value, IRedInteger current) => ValueToRedInt(Enum.Parse(enumType, value), current);

    // This could exist outside of this helper class
    public static IRedInteger ValueToRedInt(object value, IRedInteger current) => current switch
    {
        CUInt8 => (CUInt8)Convert.ToByte(value),
        CUInt16 => (CUInt16)Convert.ToUInt16(value),
        CUInt32 => (CUInt32)Convert.ToUInt32(value),
        CUInt64 => (CUInt64)Convert.ToUInt64(value),
        CInt8 => (CInt8)Convert.ToSByte(value),
        CInt16 => (CInt16)Convert.ToInt16(value),
        CInt32 => (CInt32)Convert.ToInt32(value),
        CInt64 => (CInt64)Convert.ToInt64(value),
        _ => throw new NotSupportedException("Only integer types are supported")
    };


    // Running IRedInteger values through ulong since it's the largest value that fits them all
    // Used for performing bitfield tests
    public static ulong RedIntToULong(IRedInteger redInteger) => redInteger switch
    {
        CUInt8 u8 => Convert.ToUInt64(u8),
        CUInt16 u16 => Convert.ToUInt64(u16),
        CUInt32 u32 => Convert.ToUInt64(u32),
        CUInt64 u64 => (ulong)u64,
        _ => 0u
    };

    
    public static string RedIntToBitfieldString(Type enumType, IRedInteger redInteger) => redInteger switch
    {
        CUInt8 u8 => UIntToBitfieldString<byte>(enumType, u8),
        CUInt16 u16 => UIntToBitfieldString<ushort>(enumType, u16),
        CUInt32 u32 => UIntToBitfieldString<uint>(enumType, u32),
        CUInt64 u64 => UIntToBitfieldString<ulong>(enumType, u64),
        _ => string.Empty
    };

    public static string UIntToBitfieldString<T>(Type enumType, T value) where T : IUnsignedNumber<T>, IBinaryInteger<T>
    {
        var none = System.Activator.CreateInstance(enumType)?.ToString() ?? "None";
        var values = new List<string>();
        foreach (var e in Enum.GetValues(enumType))
        {
            T ev = (T)Convert.ChangeType(e, typeof(T));
            if (ev > T.Zero && (value & ev) == ev)
            {
                // This cannot actually be null, since the value for e is defined by the enum
                values.Add(Enum.GetName(enumType, e) ?? "");
            }
        }
        return values.Count > 0 ? string.Join(", ", values) : none;
    }
}
