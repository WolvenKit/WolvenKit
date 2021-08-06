using System.Text;

namespace WolvenKit.Common.Model
{
    public readonly struct SAsciiString
    {
        private readonly byte[] _strBytes;

        public SAsciiString(string input)
        {
            _strBytes = Encoding.ASCII.GetBytes(input);
        }

        public override string ToString() => Encoding.ASCII.GetString(_strBytes);
    }
}
