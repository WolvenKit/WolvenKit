using System;
using System.Collections.Generic;
using System.IO;
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

    private static readonly Dictionary<ulong, Type> s_typeHashes = new();
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
            var type = GetTypeFromEnum(enumType);
            var arrType = typeof(CArray<>).MakeGenericType(type);

            var redName = RedReflection.GetRedTypeFromCSType(type);

            s_typeHashes.Add(FNV1A64HashAlgorithm.HashString(redName), type);
            s_typeHashes.Add(FNV1A64HashAlgorithm.HashString($"array:{redName}"), arrType);
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
            var type = s_typeHashes[typeHash];

            var numValues = BaseReader.ReadUInt32();
            for (var j = 0; j < numValues; j++)
            {
                flatTypeValues[typeHash].Add(Read(type));
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

    private static Type GetTypeFromEnum(ETweakType enumType)
        => enumType switch
        {
            ETweakType.CName => typeof(CName),
            ETweakType.CString => typeof(CString),
            ETweakType.TweakDBID => typeof(TweakDBID),
            ETweakType.CResource => typeof(CResourceAsyncReference<CResource>),
            ETweakType.CFloat => typeof(CFloat),
            ETweakType.CBool => typeof(CBool),
            ETweakType.CUint8 => typeof(CUInt8),
            ETweakType.CUint16 => typeof(CUInt16),
            ETweakType.CUint32 => typeof(CUInt32),
            ETweakType.CUint64 => typeof(CUInt64),
            ETweakType.CInt8 => typeof(CInt8),
            ETweakType.CInt16 => typeof(CInt16),
            ETweakType.CInt32 => typeof(CInt32),
            ETweakType.CInt64 => typeof(CInt64),
            ETweakType.CColor => typeof(CColor),
            ETweakType.CEulerAngles => typeof(EulerAngles),
            ETweakType.CQuaternion => typeof(Quaternion),
            ETweakType.CVector2 => typeof(Vector2),
            ETweakType.CVector3 => typeof(Vector3),
            ETweakType.LocKey => typeof(gamedataLocKeyWrapper),
            _ => throw new ArgumentOutOfRangeException(nameof(enumType))
        };

    public override CName ReadCName() => BaseReader.ReadLengthPrefixedString();

    public override IRedArray<T> ReadCArray<T>(uint size)
    {
        var array = new CArray<T>();

        var cnt = BaseReader.ReadInt32();
        for (var i = 0; i < cnt; i++)
        {
            array.Add(Read(typeof(T)));
        }

        return array;
    }

    public override IRedResourceAsyncReference<T> ReadCResourceAsyncReference<T>() =>
        new CResourceAsyncReference<T>
        {
            DepotPath = BaseReader.ReadUInt64()
        };

    public override RedBaseClass ReadClass(Type type, uint size)
    {
        var instance = RedTypeManager.Create(type);

        var unk1 = BaseReader.ReadByte();

        var typeInfo = RedReflection.GetTypeInfo(instance);
        while (true)
        {
            var varName = BaseReader.ReadLengthPrefixedString();
            if (varName == "None")
            {
                break;
            }
            var valueTypeName = BaseReader.ReadLengthPrefixedString();
            var (valueType, valueFlags) = RedReflection.GetCSTypeFromRedType(valueTypeName);

            BaseReader.ReadUInt32();

            var propertyInfo = RedReflection.GetPropertyByRedName(type, varName);
            IRedType value;

            if (propertyInfo == null)
            {
                value = Read(valueType, 0, Flags.Empty);
                instance.SetProperty(varName, value);
            }
            else
            {
                value = Read(valueType, 0, valueFlags);

                if (valueType != propertyInfo.Type)
                {
                    var args = new InvalidRTTIEventArgs(propertyInfo.Type, valueType, value);
                    if (!HandleParsingError(args))
                    {
                        var propName = $"{RedReflection.GetRedTypeFromCSType(instance.GetType())}.{varName}";
                        throw new InvalidRTTIException(propName, propertyInfo.Type, valueType);

                    }
                    value = args.Value;
                }


                instance.SetProperty(propertyInfo.RedName, value);
            }
        }

        return instance;
    }
}
