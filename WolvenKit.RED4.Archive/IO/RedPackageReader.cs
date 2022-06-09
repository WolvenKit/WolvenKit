using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class RedPackageReader : Red4Reader
    {
        public RedPackageSettings Settings = new();

        public RedPackageReader(Stream input) : this(new BinaryReader(input, Encoding.UTF8, false))
        {
        }

        public RedPackageReader(BinaryReader reader) : base(reader)
        {
        }

        public override void ReadClass(RedBaseClass cls, uint size)
        {
            var typeInfo = RedReflection.GetTypeInfo(cls);

            var baseOff = BaseStream.Position;
            var fieldCount = _reader.ReadUInt16();
            //var unk = _reader.ReadUInt16();
            var fields = BaseStream.ReadStructs<RedPackageFieldHeader>(fieldCount);

            foreach (var f in fields)
            {
                var varName = GetStringValue(f.nameID);
                var typeName = GetStringValue(f.typeID);
                var (fieldType, flags) = RedReflection.GetCSTypeFromRedType(typeName);

                var prop = typeInfo.GetPropertyInfoByRedName(varName);
                if (prop == null)
                {
                    prop = typeInfo.AddDynamicProperty(varName, typeName);
                }

                IRedType value;

                BaseStream.Position = baseOff + f.offset;
                if (prop.IsDynamic)
                {
                    value = Read(fieldType, 0, Flags.Empty);
                    cls.SetProperty(varName, value);
                }
                else
                {
                    if (fieldType != prop.Type)
                    {
                        var propName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";
                        throw new InvalidRTTIException(propName, prop.Type, fieldType);
                    }

                    value = Read(prop.Type, 0, flags);
                    cls.SetProperty(prop.RedName, value);
                }
            }
        }

        public override TweakDBID ReadTweakDBID()
        {
            if (header.version == 2 || header.version == 3)
            {
                var length = _reader.ReadInt16();
                return Encoding.UTF8.GetString(_reader.ReadBytes(length));
            }

            if (header.version == 04)
            {
                return base.ReadTweakDBID();
            }

            throw new NotImplementedException(nameof(ReadTweakDBID));
        }

        public override CBitField<T> ReadCBitField<T>()
        {
            var cnt = _reader.ReadByte();

            var enumString = "";
            for (var i = 0; i < cnt; i++)
            {
                var index = _reader.ReadUInt16();
                if (index == 0)
                {
                    throw new TodoException();
                }

                if (!string.IsNullOrEmpty(enumString))
                {
                    enumString += ", ";
                }

                enumString += GetStringValue(index);
            }

            if (string.IsNullOrEmpty(enumString))
            {
                return default(T);
            }

            return Enum.Parse<T>(enumString);
        }

        public override IRedHandle<T> ReadCHandle<T>()
        {
            var handle = new CHandle<T>();

            int pointer;
            if (header.version == 2)
            {
                pointer = _reader.ReadInt16();
            }
            else if (header.version == 3 || header.version == 04)
            {
                pointer = _reader.ReadInt32();
            }
            else
            {
                throw new NotImplementedException(nameof(ReadCHandle));
            }

            if (!HandleQueue.ContainsKey(pointer))
            {
                HandleQueue.Add(pointer, new List<IRedBaseHandle>());
            }

            HandleQueue[pointer].Add(handle);

            return handle;
        }

        public override IRedWeakHandle<T> ReadCWeakHandle<T>()
        {
            var handle = new CWeakHandle<T>();

            var pointer = _reader.ReadInt32();
            if (!HandleQueue.ContainsKey(pointer))
            {
                HandleQueue.Add(pointer, new List<IRedBaseHandle>());
            }

            HandleQueue[pointer].Add(handle);

            return handle;
        }

        public override IRedResourceAsyncReference<T> ReadCResourceAsyncReference<T>()
        {
            var index = _reader.ReadInt16();

            if (index >= 0 && index < importsList.Count)
            {
                var import = (PackageImport)importsList[index - 0];

                return new CResourceAsyncReference<T>
                {
                    DepotPath = import.DepotPath != "" ? import.DepotPath : import.Hash,
                    Flags = import.Flags
                };
            }

            return new CResourceAsyncReference<T>
            {
                // TODO: Find a better way (written as -1)
                DepotPath = "INVALID",
                Flags = InternalEnums.EImportFlags.Default
            };
        }

        public override IRedResourceReference<T> ReadCResourceReference<T>()
        {
            var index = _reader.ReadInt16();

            if (index >= 0 && index < importsList.Count)
            {
                var import = (PackageImport)importsList[index - 0];

                return new CResourceReference<T>
                {
                    DepotPath = import.DepotPath != "" ? import.DepotPath : import.Hash,
                    Flags = import.Flags
                };
            }

            return new CResourceReference<T>
            {
                // TODO: Find a better way (written as -1)
                DepotPath = "INVALID",
                Flags = InternalEnums.EImportFlags.Default
            };
        }

        public override DataBuffer ReadDataBuffer() => base.ReadDataBuffer();

        public override NodeRef ReadNodeRef()
        {
            var length = _reader.ReadInt16();
            return Encoding.UTF8.GetString(_reader.ReadBytes(length));
        }

        public override LocalizationString ReadLocalizationString() =>
            new()
            {
                Unk1 = _reader.ReadUInt64(),
                Value = ReadSimpleString()
            };

        public string ReadSimpleString()
        {
            var length = _reader.ReadUInt16();
            return Encoding.UTF8.GetString(_reader.ReadBytes(length));
        }

        public override CString ReadCString() => ReadSimpleString();

    }
}
