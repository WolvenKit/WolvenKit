using System;

namespace WolvenKit.RED4.Types
{
    [RED("CDateTime")]
    public class CDateTime : IRedPrimitive
    {
        public DateTime Value { get; set; }

        public static CDateTime Now => new() { Value = DateTime.Now };

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
            res = null;
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
            i |= 0X1FF & Convert.ToUInt32(Value.Hour);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(Value.Minute);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(Value.Second);
            i <<= 0xA;
            i |= 0x3FF & Convert.ToUInt32(Value.Millisecond);
            i <<= 0xC;

            //Date
            i |= 0xFFF & Convert.ToUInt32(Value.Year);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(Value.Month - 1);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(Value.Day - 1);
            i <<= 0xA;

            return i;
        }

        public static implicit operator CDateTime(DateTime value) => new() { Value = value };
        public static implicit operator DateTime(CDateTime value) => value.Value;

        public static implicit operator CDateTime(ulong value) => CDateTime.Parse(value);
        public static implicit operator ulong(CDateTime value) => value.ToUInt64();
    }
}
