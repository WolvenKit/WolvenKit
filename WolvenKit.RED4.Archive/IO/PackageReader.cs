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
    public partial class PackageReader : Red4Reader
    {
        public PackageReader(Stream input) : base(input)
        {
        }

        public PackageReader(Stream input, Encoding encoding) : base(input, encoding)
        {
        }

        public PackageReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
        }

        public PackageReader(BinaryReader reader) : base(reader)
        {
        }

        public RedBaseClass ReadClass(Type type)
        {
            var instance = RedTypeManager.Create(type);

            var baseOff = BaseStream.Position;
            var fieldCount = _reader.ReadUInt16();
            //var unk = _reader.ReadUInt16();
            var fields = BaseStream.ReadStructs<Package04FieldHeader>(fieldCount);

            foreach (var f in fields)
            {
                var varName = GetStringValue(f.nameID);
                var typeName = GetStringValue(f.typeID);
                var (fieldType, flags) = RedReflection.GetCSTypeFromRedType(typeName);

                var prop = RedReflection.GetPropertyByRedName(type, varName);

                IRedType value;

                BaseStream.Position = baseOff + f.offset;
                if (prop == null)
                {
                    value = Read(fieldType, 0, Flags.Empty);
                    instance.SetProperty(varName, value);
                }
                else
                {
                    if (fieldType != prop.Type)
                    {
                        var propName = $"{RedReflection.GetRedTypeFromCSType(instance.GetType())}.{varName}";
                        throw new InvalidRTTIException(propName, prop.Type, fieldType);
                    }

                    value = Read(prop.Type, 0, flags);
                    instance.SetProperty(prop.RedName, value);
                }
            }

            return instance;
        }

        public override IRedType Read(Type type, uint size = 0, Flags flags = null)
        {
            if (typeof(RedBaseClass).IsAssignableFrom(type))
            {
                return ReadClass(type);
            }

            return base.Read(type, size, flags);
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
