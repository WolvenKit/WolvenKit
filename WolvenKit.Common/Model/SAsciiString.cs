using System.Linq;
using System.Text;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Model
{
    public readonly struct SAsciiString //: IEquatable<SAsciiString>
    {
        private readonly byte[] _strBytes;

        public SAsciiString(string input) => _strBytes = Encoding.ASCII.GetBytes(input);

        public override string ToString() => Encoding.ASCII.GetString(_strBytes);

        //public override bool Equals(object obj)
        //{
        //    if (obj is SAsciiString asciiString)
        //    {
        //        return Equals(asciiString);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool Equals(SAsciiString other) => Enumerable.SequenceEqual(_strBytes, other._strBytes);

        //public static bool operator ==(SAsciiString left, SAsciiString right)
        //{
        //    return left.Equals(right);
        //}

        //public static bool operator !=(SAsciiString left, SAsciiString right)
        //{
        //    return !(left == right);
        //}

        public override int GetHashCode() => _strBytes.GetHashCode();


    }
}
