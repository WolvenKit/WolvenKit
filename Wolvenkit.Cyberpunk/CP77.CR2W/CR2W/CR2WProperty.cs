using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CR2WProperty
    {
        [FieldOffset(0)]
        public ushort className;

        [FieldOffset(2)]
        public ushort classFlags;

        [FieldOffset(4)]
        public ushort propertyName;

        [FieldOffset(6)]
        public ushort propertyFlags;

        [FieldOffset(8)]
        public ulong hash;
    }

    public class CR2WPropertyWrapper
    {
        private CR2WProperty _property;
        public CR2WProperty Property {
            get => _property;
            set => _property = value;
        }

        public CR2WPropertyWrapper()
        {
        }

        public CR2WPropertyWrapper(CR2WProperty property)
        {
            _property = property;
        }
        
    }
}