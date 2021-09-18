using System;

namespace WolvenKit.RED4.TweakDB.Types
{
    public interface IPrimitive : IType
    {
        public string GetValueString();

        public static IType Parse(string s, Type type)
        {
            if (typeof(IPrimitive).IsAssignableFrom(type))
            {
                return Serialization.Serialization.GetEnumFromType(type) switch
                {
                    ETweakType.CName => (CName)s,
                    ETweakType.CString => (CString)s,
                    ETweakType.CFloat => (CFloat)float.Parse(s),
                    ETweakType.CBool => (CBool)bool.Parse(s),
                    ETweakType.CUint8 => (CUint8)byte.Parse(s),
                    ETweakType.CUint16 => (CUint16)ushort.Parse(s),
                    ETweakType.CUint32 => (CUint32)uint.Parse(s),
                    ETweakType.CUint64 => (CUint64)ulong.Parse(s),
                    ETweakType.CInt8 => (CInt8)sbyte.Parse(s),
                    ETweakType.CInt16 => (CInt16)short.Parse(s),
                    ETweakType.CInt32 => (CInt32)int.Parse(s),
                    ETweakType.CInt64 => (CInt64)long.Parse(s),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
