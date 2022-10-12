using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using Activator = System.Activator;

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
                var redTypeInfos = RedReflection.GetRedTypeInfos(typeName);

                var prop = typeInfo.GetPropertyInfoByRedName(varName);
                if (prop == null)
                {
                    prop = typeInfo.AddDynamicProperty(varName, typeName);
                }

                IRedType value;

                BaseStream.Position = baseOff + f.offset;
                if (prop.IsDynamic)
                {
                    value = Read(redTypeInfos, 0);
                    cls.SetProperty(varName, value);
                }
                else
                {
                    value = Read(redTypeInfos, 0);

                    if (fieldType != prop.Type)
                    {
                        var args = new InvalidRTTIEventArgs(prop.Type, fieldType, value);
                        if (!HandleParsingError(args))
                        {
                            var propName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";
                            throw new InvalidRTTIException(propName, prop.Type, fieldType);
                            
                        }
                        value = args.Value;
                    }

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

        public override IRedBitField ReadCBitField(List<RedTypeInfo> redTypeInfos, uint size)
        {
            if (redTypeInfos.Count != 1)
            {
                throw new TodoException();
            }

            var enumInfo = RedReflection.GetEnumTypeInfo(redTypeInfos[0].RedObjectType);
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

                enumString += enumInfo.GetCSNameFromRedName(GetStringValue(index));
            }

            var type = RedReflection.GetFullType(redTypeInfos);
            if (string.IsNullOrEmpty(enumString))
            {
                return (IRedBitField)Activator.CreateInstance(type);
            }
            return (IRedBitField)Activator.CreateInstance(type, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { Enum.Parse(redTypeInfos[0].RedObjectType, enumString) }, null);
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

        public override IRedWeakHandle ReadCWeakHandle(List<RedTypeInfo> redTypeInfos, uint size)
        {
            var type = RedReflection.GetFullType(redTypeInfos);
            var result = (IRedWeakHandle)Activator.CreateInstance(type);

            var pointer = _reader.ReadInt32();
            if (!HandleQueue.ContainsKey(pointer))
            {
                HandleQueue.Add(pointer, new List<IRedBaseHandle>());
            }

            HandleQueue[pointer].Add(result);

            return result;
        }

        public override IRedResourceAsyncReference ReadCResourceAsyncReference(List<RedTypeInfo> redTypeInfos, uint size)
        {
            if (redTypeInfos.Count != 2)
            {
                throw new TodoException();
            }

            var depotPath = (CName)0;
            var flags = InternalEnums.EImportFlags.Default;

            var index = _reader.ReadInt16();
            if (index >= 0 && index < importsList.Count)
            {
                depotPath = importsList[index].DepotPath;
                flags = importsList[index].Flags;
            }

            var type = RedReflection.GetFullType(redTypeInfos);
            var result = (IRedResourceAsyncReference)Activator.CreateInstance(type, depotPath, flags);

            return result;
        }

        public override IRedResourceReference ReadCResourceReference(List<RedTypeInfo> redTypeInfos, uint size)
        {
            if (redTypeInfos.Count != 2)
            {
                throw new TodoException();
            }

            var depotPath = (CName)0;
            var flags = InternalEnums.EImportFlags.Default;

            var index = _reader.ReadInt16();
            if (index >= 0 && index < importsList.Count)
            {
                depotPath = importsList[index].DepotPath;
                flags = importsList[index].Flags;
            }

            var type = RedReflection.GetFullType(redTypeInfos);
            var result = (IRedResourceReference)Activator.CreateInstance(type, depotPath, flags);

            return result;
        }

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
