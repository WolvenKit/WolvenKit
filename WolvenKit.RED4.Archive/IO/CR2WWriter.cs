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
        private readonly List<(string, string, ushort)> _imports = new();

        public CR2WWriter(Stream output) : base(output)
        {
        }

        public CR2WWriter(Stream output, Encoding encoding) : base(output, encoding)
        {
        }

        public CR2WWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
        {
        }

        public List<(string, string, ushort)> GetImportList() => new(_imports);

        public override void WriteClass(IRedClass cls)
        {
            if (cls is IRedCustomData customCls)
            {
                customCls.CustomWrite(this);
                return;
            }

            _writer.Write((byte)0);

            var typeInfo = RedReflection.GetTypeInfo(cls.GetType());
            foreach (var propertyInfo in typeInfo.PropertyInfos)
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

        public override void Write<T>(CArray<T> instance)
        {
            _writer.Write((uint)instance.Count);
            foreach (var element in instance)
            {
                Write(element);
            }
        }

        public override void Write<T>(CArrayFixedSize<T> instance)
        {
            var count = instance.Count(e => e != null);

            _writer.Write((uint)count);
            foreach (var element in instance)
            {
                if (element == null)
                {
                    continue;
                }

                Write(element);
            }
        }

        public override void Write<T>(CStatic<T> instance)
        {
            var count = instance.Count(e =>  e != null);

            _writer.Write((uint)count);
            foreach (var element in instance)
            {
                if (element == null)
                {
                    continue;
                }

                Write(element);
            }
        }

        public override void Write(IRedResourceReference instance)
        {
            if (instance.DepotPath == "")
            {
                _writer.Write((ushort)0);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            if (!_imports.Contains(val))
            {
                _imports.Add(val);
            }

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        public override void Write(IRedResourceAsyncReference instance)
        {
            if (instance.DepotPath == "")
            {
                _writer.Write((ushort)0);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            if (!_imports.Contains(val))
            {
                _imports.Add(val);
            }

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }
    }
}
