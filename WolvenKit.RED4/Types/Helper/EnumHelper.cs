using System.Globalization;
using System.Numerics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public class EnumHelper
{
    public static bool IsBitfield(Type enumType) => enumType.GetCustomAttribute<FlagsAttribute>() != null;

    public static string RedIntToEnumString(Type enumType, IRedInteger redInteger) => Enum.GetName(enumType, RedIntToULong(redInteger)) ?? redInteger.ToString(CultureInfo.CurrentCulture);

    // Running IRedInteger values through ulong since it's the largest value that fits them all
    public static ulong RedIntToULong(IRedInteger redInteger) => redInteger switch
    {
        CUInt8 u8 => Convert.ToUInt64(u8),
        CUInt16 u16 => Convert.ToUInt64(u16),
        CUInt32 u32 => Convert.ToUInt64(u32),
        CUInt64 u64 => (ulong)u64,
        _ => 0u
    };

    public static IRedInteger ULongToRedInt(ulong ul, IRedInteger current) => current switch
    {
        CUInt8 => (CUInt8)Convert.ToByte(ul),
        CUInt16 => (CUInt16)Convert.ToUInt16(ul),
        CUInt32 => (CUInt32)Convert.ToUInt32(ul),
        CUInt64 => (CUInt64)ul,
        _ => throw new NotSupportedException()
    };

    public static ulong StringToULong(Type enumType, string value) => Convert.ToUInt64(Enum.Parse(enumType, value));

    public static IRedInteger StringToRedInt(Type enumType, string value, IRedInteger current) => ULongToRedInt(StringToULong(enumType, value), current);

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
