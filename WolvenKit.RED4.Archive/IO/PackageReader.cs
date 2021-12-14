using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.RED4.Archive.CR2W;
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

        public IRedClass ReadClass(Type type)
        {
            var instance = RedTypeManager.Create(type);

            var baseOff = BaseStream.Position;
            var fieldCount = _reader.ReadUInt16();
            //var unk = _reader.ReadUInt16();
            var fields = BaseStream.ReadStructs<PackageFieldHeader>(fieldCount);

            foreach (var f in fields)
            {
                var varName = GetStringValue(f.nameID);
                var typeName = GetStringValue(f.typeID);
                var (fieldType, flags) = RedReflection.GetCSTypeFromRedType(typeName);

                var prop = RedReflection.GetPropertyByRedName(type, varName);
                BaseStream.Position = baseOff + f.offset;
                if (prop == null)
                {
                    var value = Read(fieldType, 0, Flags.Empty);
                    RedReflection.AddDynamicProperty(instance, varName, value);
                }
                else
                {
                    var value = Read(fieldType, 0, flags);
                    prop.SetValue(instance, value);
                }
            }

            return instance;
        }

        public override IRedType Read(Type type, uint size = 0, Flags flags = null)
        {
            if (typeof(IRedClass).IsAssignableFrom(type))
            {
                return ReadClass(type);
            }
            
            return base.Read(type, size, flags);
        }

        public override CBitField<T> ReadCBitField<T>()
        {
            var cnt = _reader.ReadByte();

            var enumString = "";
            for (int i = 0; i < cnt; i++)
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
            return _outputFile.HandleManager.CreateCHandle<T>(_reader.ReadInt32() - 0);
        }

        public override IRedWeakHandle<T> ReadCWeakHandle<T>()
        {
            return _outputFile.HandleManager.CreateCWeakHandle<T>(_reader.ReadInt32() - 0);
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

        public override NodeRef ReadNodeRef()
        {
            var length = _reader.ReadInt16();
            return Encoding.UTF8.GetString(_reader.ReadBytes(length));
        }
    }
}
