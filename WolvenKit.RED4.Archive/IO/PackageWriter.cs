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
    public partial class PackageWriter : Red4Writer
    {

        public PackageWriter(Stream output) : base(output)
        {
        }

        public PackageWriter(Stream output, Encoding encoding) : base(output, encoding)
        {
        }

        public PackageWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
        {
        }

        public override void Write(CRUID val)
        {
            _writer.Write(val);
            _cruids.Add(val);
        }

        public override void WriteClass(IRedClass cls)
        {
            if (cls is IRedCustomData customCls)
            {
                customCls.CustomWrite(this);
                return;
            }

            var typeInfo = RedReflection.GetTypeInfo(cls.GetType());


            var nonDefaultProperties = new List<RedReflection.ExtendedPropertyInfo>();

            foreach (var propertyInfo in typeInfo.PropertyInfos)
            {
                var value = propertyInfo.GetValue(cls);
                if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), propertyInfo, value))
                {
                    continue;
                }
                nonDefaultProperties.Add(propertyInfo);
            }

            _writer.Write((ushort)nonDefaultProperties.Count);
            var currentDataPosition = BaseStream.Position + nonDefaultProperties.Count * 8;
            var descStartPosition = BaseStream.Position;

            foreach (var propertyInfo in nonDefaultProperties)
            {
                var value = propertyInfo.GetValue(cls);
                var redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags.Clone());

                BaseStream.Position = descStartPosition + nonDefaultProperties.IndexOf(propertyInfo) * 8;

                CNameRef.Add(_writer.BaseStream.Position, propertyInfo.RedName);
                _writer.Write(GetStringIndex(propertyInfo.RedName));

                CNameRef.Add(_writer.BaseStream.Position, redTypeName);
                _writer.Write(GetStringIndex(redTypeName));

                _writer.Write((uint)(currentDataPosition - descStartPosition + 2));

                BaseStream.Position = currentDataPosition;
                // write data, prefixed with size?
                Write((IRedType)value);
                currentDataPosition = BaseStream.Position;
            }

            if (cls is IRedAppendix app)
            {
                app.Write(this);
            }
        }

        public override void Write(IRedHandle instance)
        {
            //if (instance.Pointer > 0)
            //{
            _targetList.Add((CurrentChunk, instance.Pointer, StringCacheList.Count, ImportCacheList.Count));
            //}

            _writer.Write(instance.Pointer + 0);
        }

        public override void Write(IRedWeakHandle instance)
        {
            //if (instance.Pointer > 0)
            //{
            _targetList.Add((CurrentChunk, instance.Pointer, StringCacheList.Count, ImportCacheList.Count));
            //}

            _writer.Write(instance.Pointer + 0);
        }

    }
}
