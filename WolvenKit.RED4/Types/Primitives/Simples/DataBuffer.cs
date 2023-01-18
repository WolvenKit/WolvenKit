using System.ComponentModel;

namespace WolvenKit.RED4.Types;

public class DataBuffer : IRedBufferWrapper, IRedBufferPointer, IRedPrimitive, IEquatable<DataBuffer>, IRedCloneable
{
    [Browsable(false)]
    public RedBuffer Buffer { get; set; }

    [Browsable(false)]
    public IParseableBuffer Data
    {
        get => Buffer.Data;
        set => Buffer.Data = value;
    }

    public DataBuffer()
    {
        Buffer = new RedBuffer();
    }

    public DataBuffer(byte[] data)
    {
        Buffer = RedBuffer.CreateBuffer(0, data);
    }


    public RedBuffer GetValue() => Buffer;
    public void SetValue(RedBuffer instance) => Buffer = instance;

    public bool Equals(DataBuffer other)
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

        return Equals((DataBuffer)obj);
    }

    public override int GetHashCode() => Buffer.GetHashCode();

    public object ShallowCopy()
    {
        return MemberwiseClone();
    }

    public object DeepCopy()
    {
        var db = new DataBuffer();
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