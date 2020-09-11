using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /*  - Format Info
     * 
     *  0000010110100001111000001010110001111110001000111011110000000000
     *  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
     *  |0 ||22  ||33  ||56  ||172     ||2018      ||7  ||15 ||0       |
     *  |  ||    ||    ||    ||        ||          ||   ||   ||________|____ 10 - Empty
     *  |  ||    ||    ||    ||        ||          ||   ||___|______________ 5  - Day - 1
     *  |  ||    ||    ||    ||        ||          ||___|___________________ 5  - Month - 1
     *  |  ||    ||    ||    ||        ||__________|________________________ 12 - Year
     *  |  ||    ||    ||    ||________|____________________________________ 10 - Millisecond
     *  |  ||    ||    ||____|______________________________________________ 6  - Second
     *  |  ||    ||____|____________________________________________________ 6  - Minute 
     *  |  ||____|__________________________________________________________ 6  - Hour
     *  |__|________________________________________________________________ 4  - Empty
     *  
     *  16/08/2018 22:33:56.172
     *  
     *  Month and day store their value in the ulong value with the day/month - 1.
     *  Because they are the only two values where their minimum value is 1 and not 0.
     *  When reading the values add 1 to the value, and when writing subtract 1 from the day/month.
     *  
     */
    /// <summary>
    /// Represents a REDEngine compatible datetime value.
    /// </summary>
    [REDMeta()]
    public sealed class CDateTime : CVariable/*, IEquatable<CDateTime>*/
    {
        /// <summary>
        /// The CDateTime value as a .NET <see cref="System.DateTime"/> object.
        /// </summary>
        private DateTime m_value;

        /// <summary>
        /// Get the underlying .NET value from this CDateTime instance.
        /// </summary>
        /// <exception cref="InvalidOperationException">When the underlying value is null</exception>
        public DateTime DValue => m_value;

        // <summary>
        /// Initialise a new instance of the CDateTime.
        /// </summary>
        /// <param name="value"></param>
        public CDateTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        /// <summary>
        /// Initialise a new instance of the CDateTime object using a .NET <see cref="System.DateTime"/> object.
        /// </summary>
        /// <param name="value"></param>
        public CDateTime(DateTime value, CVariable parent, string name, CR2WFile cr2w = null) : base(cr2w, parent, name)
        {
            m_value = value;
        }

        /// <summary>
        /// Initialise a new instance of the CDateTime object using a formatted redengine UInt64 value.
        /// If the value is formatted incorrectly, Min value will be used.
        /// </summary>
        /// <param name="value">A formatted UInt64 representing a datetime value.</param>
        public CDateTime(UInt64 value, CVariable parent, string name, CR2WFile cr2w = null) : base(cr2w, parent, name)
        {
            TryParse(this, value);
        }

        /// <summary>
        /// Get a CDateTime object set to the current time of the system.
        /// !! Do not use as CVariable for serialization !!
        /// </summary>
        public static CDateTime Now => new CDateTime(DateTime.Now, null, "");

        /// <summary>
        /// Convert a CDateTime value into a redengine UInt64 compatible representation.
        /// </summary>
        /// <returns>
        /// A formatted UInt64 if the value is not null, and 0 if it is.
        /// </returns>
        public UInt64 ToUInt64()
        {
            var i = 0UL;
            var d = m_value;

            //Time
            i |= 0X1FF & Convert.ToUInt32(d.Hour);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(d.Minute);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(d.Second);
            i <<= 0xA;
            i |= 0x3FF & Convert.ToUInt32(d.Millisecond);
            i <<= 0xC;

            //Date
            i |= 0xFFF & Convert.ToUInt32(d.Year);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(d.Month - 1);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(d.Day - 1);
            i <<= 0xA;

            return i;
        }

        /// <summary>
        /// Sets the value of CDatetIme object from a UInt64 formatted representation.
        /// </summary>
        /// <param name="datetime">The CDateTime instance to set the value of.</param>
        /// <param name="value">The formatted UInt64 value to set the datetime to.</param>
        /// <returns>Boolean indicating if the value was sucsessfully set.</returns>
        public static bool TryParse(CDateTime datetime, UInt64 value)
        {
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

            try
            {
                datetime.m_value = new DateTime(year, month, day, hour, minute, second, millisecond);
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="CDateTime"/> object represent the same value.
        /// </summary>
        /// <param name="other">A <see cref="CDateTime"/> to compare to this instance.</param>
        /// <returns>true if other is equal to this instance, otherwise false.</returns>
        //public bool Equals(CDateTime other)
        //{
        //    if (other is null)
        //        return false;

        //    return m_value.Equals(this);
        //}

        /// <summary>
        /// Returns a string representation of this instance.
        /// </summary>
        /// <returns>
        /// A formatted string if the value is not null and an empty string if it is.
        /// </returns>
        public override string ToString()
        {
            return m_value.ToString();
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="object"/> represent the same value.
        /// </summary>
        /// <param name="obj">A <see cref="object"/> to compare to this instance.</param>
        /// <returns>true if other is a CDateTime inmstance and equal to this instance, otherwise false.</returns>
        //public override bool Equals(object obj)
        //{
        //    if (obj is CDateTime dt)
        //        return this.Equals(dt);

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return RuntimeHelpers.GetHashCode(this);
        //}

        public override void Read(BinaryReader file, uint size)
        {
            TryParse(this, file.ReadUInt64());
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(this.ToUInt64());
        }

        //public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        //{
        //    return new CDateTime(cr2w, parent, name);
        //}

        //public static bool operator ==(CDateTime left, CDateTime right)
        //{
        //    if (ReferenceEquals(left, right))
        //        return true;

        //    if (left is null)
        //        return false;

        //    return left.Equals(right);
        //}

        //public static bool operator !=(CDateTime left, CDateTime right)
        //{
        //    if (ReferenceEquals(left, right))
        //        return false;

        //    if (left is null)
        //        return true;

        //    return !left.Equals(right);
        //}

        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(this.GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteElementString("DateTimeString", this.ToString());
        //        ser.WriteEndObject(xw);
        //    }
        //}
    }
}