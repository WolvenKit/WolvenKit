using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.TweakDB;

/// <summary>
/// TODO logging?
/// </summary>
public class TweakDBReader : Red4Reader
{
    private const uint s_recordSeed = 0x5EEDBA5E;

    private static readonly Dictionary<ulong, List<RedTypeInfo>> s_typeHashes = new();
    private static readonly Dictionary<uint, Type> s_recordHashes = new();

    public TweakDBReader(Stream input) : base(input)
    {
    }

    public TweakDBReader(Stream input, Encoding encoding) : base(input, encoding)
    {
    }

    public TweakDBReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
    {
    }

    public TweakDBReader(BinaryReader reader) : base(reader)
    {
    }

    static TweakDBReader()
    {
        foreach (var enumType in Enum.GetValues<ETweakType>())
        {
            var redName = GetRedTypeFromEnum(enumType);
            s_typeHashes.Add(FNV1A64HashAlgorithm.HashString(redName), RedReflection.GetRedTypeInfos(redName));

            redName = $"array:{redName}";
            s_typeHashes.Add(FNV1A64HashAlgorithm.HashString(redName), RedReflection.GetRedTypeInfos(redName));
        }

        var gameDataRegex = new Regex("gamedata(.*)_Record");
        foreach (var (redName, type) in RedReflection.GetTypes())
        {
            var match = gameDataRegex.Match(redName);
            if (match.Success)
            {
                s_recordHashes[Core.Murmur3.Murmur32.Hash(match.Groups[1].Value, s_recordSeed)] = type;
            }
        }
    }

    public EFileReadErrorCodes ReadFile(out TweakDB file)
    {
        var id = BaseStream.ReadStruct<uint>();
        if (id != TweakDB.Magic)
        {
            file = null;
            return EFileReadErrorCodes.NoTweakDB;
        }

        var fileHeader = BaseStream.ReadStruct<Header>();
        if (fileHeader.blobVersion != TweakDB.BlobVersion || fileHeader.parserVersion != TweakDB.ParserVersion)
        {
            file = null;
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        file = new TweakDB();

        ReadFlats(fileHeader.flatsOffset, file.Flats);
        ReadRecords(fileHeader.recordsOffset, file.Records);
        ReadQueries(fileHeader.queriesOffset, file.Queries);
        ReadGroupTags(fileHeader.groupTagsOffset, file.GroupTags);

        return EFileReadErrorCodes.NoError;
    }

    private void ReadFlats(int offset, FlatsPool pool)
    {
        Position = offset;

        var flatTypeCounts = new Dictionary<ulong, uint>();
        var numFlatTypes = BaseReader.ReadInt32();
        for (var i = 0; i < numFlatTypes; i++)
        {
            var typeHash = BaseReader.ReadUInt64();
            var typeCount = BaseReader.ReadUInt32();
            flatTypeCounts.Add(typeHash, typeCount);
        }

        var flatTypeValues = new Dictionary<ulong, List<IRedType>>();
        foreach (var (typeHash, typeCount) in flatTypeCounts)
        {
            flatTypeValues[typeHash] = new List<IRedType>();
            var redTypeInfos = s_typeHashes[typeHash];

            var numValues = BaseReader.ReadUInt32();
            for (var j = 0; j < numValues; j++)
            {
                flatTypeValues[typeHash].Add(Read(redTypeInfos));
            }

            var numKeys = BaseReader.ReadUInt32();
            for (var j = 0; j < numKeys; j++)
            {
                var keyHash = ReadTweakDBID();
                var valueIndex = BaseReader.ReadInt32();

                pool.Add(keyHash, flatTypeValues[typeHash][valueIndex]);
            }
        }
    }

    private void ReadRecords(int offset, RecordsPool pool)
    {
        Position = offset;

        var numRecords = BaseReader.ReadInt32();
        for (var i = 0; i < numRecords; i++)
        {
            var id = BaseReader.ReadUInt64();
            var key = BaseReader.ReadUInt32();

            if (s_recordHashes.ContainsKey(key))
            {
                pool.Add(id, s_recordHashes[key]);
            }
        }
    }

    private void ReadQueries(int offset, QueriesPool pool)
    {
        Position = offset;

        var numQueries = BaseReader.ReadInt32();
        for (var i = 0; i < numQueries; i++)
        {
            var entries = new List<TweakDBID>();

            var tdbName = ReadTweakDBID();
            var numResults = BaseReader.ReadUInt32();
            for (var j = 0; j < numResults; j++)
            {
                entries.Add(ReadTweakDBID());
            }

            pool.Add((ulong)tdbName, entries);
        }
    }

    private void ReadGroupTags(int offset, GroupTagsPool pool)
    {
        Position = offset;

        var numGroupTags = BaseReader.ReadInt32();
        for (var i = 0; i < numGroupTags; i++)
        {
            pool.Add((ulong)ReadTweakDBID(), BaseReader.ReadByte());
        }
    }

    private static string GetRedTypeFromEnum(ETweakType enumType)
        => enumType switch
        {
            ETweakType.CName => "CName",
            ETweakType.CString => "String",
            ETweakType.TweakDBID => "TweakDBID",
            ETweakType.CResource => "raRef:CResource",
            ETweakType.CFloat => "Float",
            ETweakType.CBool => "Bool",
            ETweakType.CUint8 => "Uint8",
            ETweakType.CUint16 => "Uint16",
            ETweakType.CUint32 => "Uint32",
            ETweakType.CUint64 => "Uint64",
            ETweakType.CInt8 => "Int8",
            ETweakType.CInt16 => "Int16",
            ETweakType.CInt32 => "Int32",
            ETweakType.CInt64 => "Int64",
            ETweakType.CColor => "Color",
            ETweakType.CEulerAngles => "EulerAngles",
            ETweakType.CQuaternion => "Quaternion",
            ETweakType.CVector2 => "Vector2",
            ETweakType.CVector3 => "Vector3",
            ETweakType.LocKey => "gamedataLocKeyWrapper",
            _ => throw new ArgumentOutOfRangeException(nameof(enumType))
        };

    public override CName ReadCName() => BaseReader.ReadLengthPrefixedString();

    public override IRedArray ReadCArray(List<RedTypeInfo> redTypeInfos, uint size, bool readAdditionalBytes = true) => base.ReadCArray(redTypeInfos, size, false);

    public override IRedResourceAsyncReference ReadCResourceAsyncReference(List<RedTypeInfo> redTypeInfos, uint size) =>
        new CResourceAsyncReference<CResource>(BaseReader.ReadUInt64());

    public override void ReadClass(RedBaseClass cls, uint size)
    {
        var unk1 = BaseReader.ReadByte();

        var typeInfo = RedReflection.GetTypeInfo(cls);
        while (true)
        {
            var varName = BaseReader.ReadLengthPrefixedString();
            if (varName == "None")
            {
                break;
            }
            var valueTypeName = BaseReader.ReadLengthPrefixedString();
            var (valueType, valueFlags) = RedReflection.GetCSTypeFromRedType(valueTypeName);
            var redTypeInfos = RedReflection.GetRedTypeInfos(valueTypeName);

            BaseReader.ReadUInt32();

            var propertyInfo = RedReflection.GetPropertyByRedName(cls.GetType(), varName);
            IRedType value;

            if (propertyInfo == null)
            {
                value = Read(redTypeInfos);
                cls.SetProperty(varName, value);
            }
            else
            {
                value = Read(redTypeInfos);

                if (valueType != propertyInfo.Type)
                {
                    var propName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";
                    var args = new InvalidRTTIEventArgs(propName, propertyInfo.Type, valueType, value);
                    if (!HandleParsingError(args))
                    {
                        throw new InvalidRTTIException(propName, propertyInfo.Type, valueType);
                    }
                    value = args.Value;
                }

                cls.SetProperty(propertyInfo.RedName, value);
            }
        }
    }
}
