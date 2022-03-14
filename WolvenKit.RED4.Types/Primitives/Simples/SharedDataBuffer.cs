using System;
using System.ComponentModel;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class SharedDataBuffer : IRedBufferWrapper, IRedPrimitive, IEquatable<SharedDataBuffer>, IRedCloneable
    {
        [Browsable(false)]
        public RedBuffer Buffer { get; set; }

        [Browsable(false)]
        public IParseableBuffer Data
        {
            get => Buffer.Data;
            set => Buffer.Data = value;
        }

        public Red4File File { get; set; }

        public bool Equals(SharedDataBuffer other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (!Equals(Buffer, other.Buffer))
            {
                return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((SharedDataBuffer)obj);
        }

        public override int GetHashCode() => (Buffer != null ? Buffer.GetHashCode() : 0);

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }

        public object DeepCopy()
        {
            var db = new SharedDataBuffer();
            if (Data is IRedCloneable irc)
            {
                db.Data = (IParseableBuffer)irc.DeepCopy();
            }
            else
            {
                db.Data = Data;
            }
            return db;
        }
    }
}
