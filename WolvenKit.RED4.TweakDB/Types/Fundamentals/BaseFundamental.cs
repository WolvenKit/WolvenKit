using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("Primitive = {typeof(T).Name}, Value = {Value}")]
    public abstract class BaseFundamental<T> : IType
        where T : struct
    {
        public abstract string Name { get; }
        public T Value { get; set; } = default;

        public abstract void Serialize(BinaryWriter writer);
    }
}
