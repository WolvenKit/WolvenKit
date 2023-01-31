using System.Text;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public partial class CR2WWriter : Red4Writer
{
    public ILoggerService LoggerService { get; set; }

    public CR2WWriter(Stream output) : base(output)
    {
    }

    public CR2WWriter(Stream output, Encoding encoding) : base(output, encoding)
    {
    }

    public CR2WWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
    {
    }

    public override void WriteClass(RedBaseClass cls)
    {
        if (cls is IRedCustomData customCls)
        {
            customCls.CustomWrite(this);
            return;
        }

        _writer.Write((byte)0);

        var typeInfo = RedReflection.GetTypeInfo(cls);
        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            string redTypeName;
            var value = cls.GetProperty(propertyInfo.RedName);
            if (!propertyInfo.IsDynamic)
            {
                if (!typeInfo.SerializeDefault && !propertyInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), propertyInfo, value))
                {
                    continue;
                }

                redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags.Clone());
            }
            else
            {
                redTypeName = propertyInfo.RedType;
            }

            CNameRef.Add(_writer.BaseStream.Position, propertyInfo.RedName);
            _writer.Write(GetStringIndex(propertyInfo.RedName));
            CNameRef.Add(_writer.BaseStream.Position, redTypeName);
            _writer.Write(GetStringIndex(redTypeName));

            var sizePos = _writer.BaseStream.Position;
            _writer.Write(0);
            Write(value);
            var endPos = _writer.BaseStream.Position;
            var bytesWritten = (uint)(endPos - sizePos);

            _writer.BaseStream.Position = sizePos;
            _writer.Write(bytesWritten);
            _writer.BaseStream.Position = endPos;
        }

        _writer.Write((ushort)0);

        if (cls is IRedAppendix app)
        {
            app.Write(this);
        }
    }

    public override void Write(SharedDataBuffer val)
    {
        if (val.File != null)
        {
            using var ms = new MemoryStream();
            using var cr2wWriter = new CR2WWriter(ms) { IsRoot = false, LoggerService = LoggerService };

            cr2wWriter.WriteFile((CR2WFile)val.File);

            ms.Seek(0, SeekOrigin.Begin);

            var buffer = ms.ToArray();
            BaseWriter.Write(buffer.Length);
            BaseWriter.Write(buffer);
        }
        else
        {
            base.Write(val);
        }
    }
}