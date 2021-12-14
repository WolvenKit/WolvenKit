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
        }

        private readonly List<Type> _ignoreCRUIDS = new()
        {
            typeof(entEffectDesc),
            typeof(worldCompiledEffectEventInfo)
        };

        public override void WriteClass(IRedClass cls)
        {
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
            nonDefaultProperties = nonDefaultProperties.OrderBy(p => p.Ordinal).ToList();

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
                if (propertyInfo.Type == typeof(CRUID) && !_ignoreCRUIDS.Contains(cls.GetType()))
                {
                    _cruids.Add((CRUID)value);
                }

                currentDataPosition = BaseStream.Position;
            }

            if (cls is IRedAppendix app)
            {
                app.Write(this);
            }
        }

        public override void Write(IRedBitField instance)
        {
            var enumString = instance.ToBitFieldString();
            if (enumString == "0")
            {
                _writer.Write((byte)0);
                return;
            }

            var flags = enumString.Split(',');

            _writer.Write((byte)flags.Length);
            for (int i = 0; i < flags.Length; i++)
            {
                var tFlag = flags[i].Trim();
                CNameRef.Add(_writer.BaseStream.Position, tFlag);
                _writer.Write(GetStringIndex(tFlag));
            }
        }

        public override void Write(IRedHandle instance)
        {
            if (instance.Pointer >= 0)
            {
                _targetList.Add((CurrentChunk, instance.Pointer, StringCacheList.Count, ImportCacheList.Count));
            }

            _writer.Write(instance.Pointer + 0);
        }

        public override void Write(IRedWeakHandle instance)
        {
            if (instance.Pointer >= 0)
            {
                _targetList.Add((CurrentChunk, instance.Pointer, StringCacheList.Count, ImportCacheList.Count));
            }

            _writer.Write(instance.Pointer + 0);
        }

        public override void Write(IRedResourceReference instance)
        {
            // TODO: Find a better way (written as -1)
            if (instance.DepotPath == "INVALID")
            {
                _writer.Write((short)-1);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        public override void Write(IRedResourceAsyncReference instance)
        {
            // TODO: Find a better way (written as -1)
            if (instance.DepotPath == "INVALID")
            {
                _writer.Write((short)-1);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        public override void Write(NodeRef val)
        {
            _writer.Write((short)(val.Text.Length));
            _writer.Write(val.Text.ToCharArray());
        }

    }
}
