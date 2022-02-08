using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WolvenKit.RED4.Types
{
    [RED("CDateTime")]
    [DebuggerDisplay("{_value,nq}")]
    public readonly struct CDateTime : IRedPrimitive<DateTime>, IEquatable<CDateTime>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DateTime _value;

        private CDateTime(DateTime value)
        {
            _value = value;
        }

        public static CDateTime Now => new(DateTime.Now);

        public static CDateTime Parse(ulong value)
        {
            var status = TryParse(value, out var res);
            if (!status)
            {
                throw new Exception();
            }

            return res;
        }

        public static bool TryParse(ulong value, out CDateTime res)
        {
            res = DateTime.MinValue;
            if (value == 0)
                return false;

            //Date
            value >>= 0xA;
            var day = Convert.ToInt32(value & 0x1F) + 1;
            value >>= 0x5;
            var month = Convert.ToInt32(value & 0x1F) + 1;
            value >>= 0x5;
            var year = Convert.ToInt32(value & 0xFFF);
            value >>= 0xC;

            //Time
            var millisecond = Convert.ToInt32(value & 0x3FF);
            value >>= 0xA;
            var second = Convert.ToInt32(value & 0x3F);
            value >>= 0x6;
            var minute = Convert.ToInt32(value & 0x3F);
            value >>= 0x6;
            var hour = Convert.ToInt32(value & 0X1FF);

            res = new DateTime(year, month, day, hour, minute, second, millisecond);

            return true;
        }

        public ulong ToUInt64()
        {
            var i = 0UL;

            //Time
            i |= 0X1FF & Convert.ToUInt32(_value.Hour);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(_value.Minute);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(_value.Second);
            i <<= 0xA;
            i |= 0x3FF & Convert.ToUInt32(_value.Millisecond);
            i <<= 0xC;

            //Date
            // TODO: Check if -1 or not, as DateTime.MinValue would return 0 if yes
            i |= 0xFFF & Convert.ToUInt32(_value.Year);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(_value.Month - 1);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(_value.Day - 1);
            i <<= 0xA;

            return i;
        }

        public static implicit operator CDateTime(DateTime value) => new(value);
        public static implicit operator DateTime(CDateTime value) => value._value;

        public static implicit operator CDateTime(ulong value) => CDateTime.Parse(value);
        public static implicit operator ulong(CDateTime value) => value.ToUInt64();


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((CDateTime)obj);
        }

        public bool Equals(CDateTime other) => Equals(_value, other._value);
    }
}
