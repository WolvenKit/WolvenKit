using RED.FNV1A;
using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WName
    {
        [FieldOffset(0)]
        public uint value;

        [FieldOffset(4)]
        public uint hash;
    }

    public class CR2WNameWrapper
    {
        private CR2WName _name;
        public CR2WName Name {
            get
            {
                _name.hash = FNV1A32HashAlgorithm.HashString(str);
                return _name;
            }
            set => _name = value;
        }

        public string str { get; set; }

        public CR2WNameWrapper()
        {
            _name = new CR2WName();
        }

        public CR2WNameWrapper(CR2WName name)
        {
            _name = name;
        }

        public void SetOffset(uint offset) => _name.value = offset;
    }
}