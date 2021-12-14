using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class CR2WWriter : Red4Writer
    {
        public CR2WWriter(Stream output) : base(output)
        {
        }

        public CR2WWriter(Stream output, Encoding encoding) : base(output, encoding)
        {
        }

        public CR2WWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
        {
        }

        public override void WriteClass(IRedClass cls)
        {
            if (cls is IRedCustomData customCls)
            {
                customCls.CustomWrite(this);
                return;
            }

            _writer.Write((byte)0);

            var typeInfo = RedReflection.GetTypeInfo(cls.GetType());
            foreach (var propertyInfo in typeInfo.GetWritableProperties())
            {
                var value = propertyInfo.GetValue(cls);
                if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), propertyInfo, value))
                {
                    continue;
                }

                var redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags.Clone());

                CNameRef.Add(_writer.BaseStream.Position, propertyInfo.RedName);
                _writer.Write(GetStringIndex(propertyInfo.RedName));
                CNameRef.Add(_writer.BaseStream.Position, redTypeName);
                _writer.Write(GetStringIndex(redTypeName));

                var sizePos = _writer.BaseStream.Position;
                _writer.Write(0);
                Write((IRedType)value);
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
    }
}
