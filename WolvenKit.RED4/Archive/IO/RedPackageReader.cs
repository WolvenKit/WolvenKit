using System.Reflection;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using Activator = System.Activator;

namespace WolvenKit.RED4.Archive.IO;

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
            var (fieldType, flags) = RedReflection.GetCSTypeFromRedType(typeName!);
            var redTypeInfos = RedReflection.GetRedTypeInfos(typeName!);
            CheckRedTypeInfos(ref redTypeInfos);

            var prop = typeInfo.GetPropertyInfoByRedName(varName!);
            if (prop == null)
            {
                prop = typeInfo.AddDynamicProperty(varName!, typeName!);
            }

            IRedType? value;

            BaseStream.Position = baseOff + f.offset;
            if (prop.IsDynamic)
            {
                value = Read(redTypeInfos, 0);
                cls.SetProperty(varName!, value);
            }
            else
            {
                ArgumentNullException.ThrowIfNull(prop.RedName);

                value = Read(redTypeInfos, 0);

                if (fieldType != prop.Type)
                {
                    var propName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";
                    var args = new InvalidRTTIEventArgs(propName, prop.Type, fieldType, value);
                    if (!HandleParsingError(args))
                    {
                        throw new InvalidRTTIException(propName, prop.Type, fieldType);
                    }
                    value = args.Value;
                }

                cls.SetProperty(prop.RedName, value);
            }

            if (CollectData)
            {
                if (prop.Name.Contains("Fact") && !prop.Name.Contains("Factor"))
                {
                    if (value is CString str1)
                    {
                        DataCollection.RawStringList.Remove(str1);
                        DataCollection.RawFactStrings.Add(str1);
                    }

                    if (value is CName str2 && str2.IsResolvable)
                    {
                        DataCollection.RawStringList.Remove(str2.GetResolvedText()!);
                        DataCollection.RawFactStrings.Add(str2.GetResolvedText()!);
                    }

                    if (value is CArray<CName> arr1)
                    {
                        foreach (var cName in arr1)
                        {
                            if (cName.IsResolvable)
                            {
                                DataCollection.RawStringList.Remove(cName.GetResolvedText()!);
                                DataCollection.RawFactStrings.Add(cName.GetResolvedText()!);
                            }
                        }
                    }
                }
            }
        }
    }

    public override TweakDBID ReadTweakDBID()
    {
        if (header.version == 2 || header.version == 3)
        {
            var result = Encoding.UTF8.GetString(_reader.ReadBytes(_reader.ReadInt16()));

            if (CollectData)
            {
                DataCollection.RawTweakStrings.Add(result);
            }

            return result;
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

            enumString += enumInfo.GetCSNameFromRedName(GetStringValue(index)!);
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (string.IsNullOrEmpty(enumString))
        {
            if (Activator.CreateInstance(type) is not IRedBitField result1)
            {
                throw new Exception();
            }
            return result1;
        }
        if (Activator.CreateInstance(type, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { Enum.Parse(redTypeInfos[0].RedObjectType, enumString) }, null) is not IRedBitField result2)
        {
            throw new Exception();
        }
        return result2;
    }

    public override IRedHandle ReadCHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
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

        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type) is not IRedHandle result)
        {
            throw new Exception();
        }

        if (!HandleQueue.ContainsKey(pointer))
        {
            HandleQueue.Add(pointer, new List<IRedBaseHandle>());
        }

        HandleQueue[pointer].Add(result);

        return result;
    }

    public override IRedWeakHandle ReadCWeakHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type) is not IRedWeakHandle result)
        {
            throw new Exception();
        }

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

        var depotPath = ResourcePath.Empty;
        var flags = InternalEnums.EImportFlags.Default;

        var index = _reader.ReadInt16();
        if (index >= 0 && index < importsList.Count)
        {
            depotPath = importsList[index].DepotPath;
            flags = importsList[index].Flags;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type, depotPath, flags) is not IRedResourceAsyncReference result)
        {
            throw new Exception();
        }

        return result;
    }

    public override IRedResourceReference ReadCResourceReference(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        var depotPath = ResourcePath.Empty;
        var flags = InternalEnums.EImportFlags.Default;

        var index = _reader.ReadInt16();
        if (index >= 0 && index < importsList.Count)
        {
            depotPath = importsList[index].DepotPath;
            flags = importsList[index].Flags;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type, depotPath, flags) is not IRedResourceReference result)
        {
            throw new Exception();
        }

        return result;
    }

    public override NodeRef ReadNodeRef()
    {
        var result = Encoding.UTF8.GetString(_reader.ReadBytes(_reader.ReadInt16()));

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(result);
            DataCollection.RawNodeRefs.Add(result);
        }

        return result;
    }

    public override LocalizationString ReadLocalizationString()
    {
        return new() { Unk1 = _reader.ReadUInt64(), Value = ReadSimpleString() };
    }

    public string ReadSimpleString()
    {
        var result = Encoding.UTF8.GetString(_reader.ReadBytes(_reader.ReadUInt16()));

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(result);
            DataCollection.RawUsedStrings.Add(result);
        }

        return result;
    }

    public override CString ReadCString() => ReadSimpleString();

}