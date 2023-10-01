using System.Text;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;


namespace WolvenKit.RED4.Archive.IO;

public partial class RedPackageWriter : Red4Writer
{
    public RedPackageSettings Settings = new();

    public RedPackageWriter(Stream output) : this(output, Encoding.UTF8, false)
    {
    }

    public RedPackageWriter(Stream output, Encoding encoding) : this(output, encoding, false)
    {
    }

    public RedPackageWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
    {
        StringCacheList = new CacheList<CName>();
        ImportCacheList = new PackageImportCacheList();
    }

    public override void Write(CRUID val) => _writer.Write(val);

    private readonly List<Type> _ignoreCRUIDS = new()
    {
        typeof(entEffectDesc),
        typeof(worldCompiledEffectEventInfo)
    };

    private readonly List<Type> _doubleHeaderCRUIDS = new()
    {
        typeof(entExternalComponent),
        typeof(entMeshComponent),
        typeof(entSkinnedMeshComponent)
    };

    public override void WriteClass(RedBaseClass cls)
    {
        var typeInfo = RedReflection.GetTypeInfo(cls);

        var nonDefaultProperties = new List<ExtendedPropertyInfo>();
        foreach (var propertyInfo in cls.GetWritableProperties())
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);

            var value = cls.GetProperty(propertyInfo.RedName);
            if (!propertyInfo.IsDynamic)
            {
                if (!typeInfo.SerializeDefault && !propertyInfo.SerializeDefault && propertyInfo.IsDefault(value))
                {
                    continue;
                }
            }

            nonDefaultProperties.Add(propertyInfo);
        }

        _writer.Write((ushort)nonDefaultProperties.Count);
        var currentDataPosition = BaseStream.Position + (nonDefaultProperties.Count * 8);
        var descStartPosition = BaseStream.Position;

        var compiledPropertyData = cls as IRedCompiledPropertyData;

        foreach (var propertyInfo in nonDefaultProperties)
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);

            string redTypeName;
            if (propertyInfo.IsDynamic)
            {
                redTypeName = propertyInfo.RedType;
            }
            else
            {
                redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags);
            }

            BaseStream.Position = descStartPosition + (nonDefaultProperties.IndexOf(propertyInfo) * 8);

            CNameRef.Add(_writer.BaseStream.Position, propertyInfo.RedName);
            _writer.Write(GetStringIndex(propertyInfo.RedName));

            CNameRef.Add(_writer.BaseStream.Position, redTypeName);
            _writer.Write(GetStringIndex(redTypeName));

            _writer.Write((uint)(currentDataPosition - descStartPosition + 2));

            BaseStream.Position = currentDataPosition;
            // write data, prefixed with size?
            
            if (compiledPropertyData != null)
            {
                compiledPropertyData.CustomWrite(this, propertyInfo.RedName);
            }
            else
            {
                var value = cls.GetProperty(propertyInfo.RedName);
                Write(value);
            }

            currentDataPosition = BaseStream.Position;
        }

        if (cls is IRedAppendix app)
        {
            app.Write(this);
        }
    }

    protected override void GenerateBufferBytes(RedBuffer buffer)
    {
        if (buffer.Data is ModifiersBuffer modifiersBuffer)
        {
            if (!modifiersBuffer.IsParsed)
            {
                return;
            }

            using var ms = new MemoryStream();
            using var modifiersBufferWriter = new ModifiersBufferWriter(ms);

            modifiersBufferWriter.WriteBuffer(modifiersBuffer);

            var newData = ms.ToArray();

            buffer.SetBytes(newData);
        }
    }

    public override void Write(IRedEnum instance)
    {
        var typeInfo = RedReflection.GetEnumTypeInfo(instance.GetInnerType());
        var valueName = typeInfo.GetRedNameFromCSName(instance.ToEnumString());

        CNameRef.Add(_writer.BaseStream.Position, valueName);
        _writer.Write(GetStringIndex(valueName));
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
        for (var i = 0; i < flags.Length; i++)
        {
            var tFlag = flags[i].Trim();
            CNameRef.Add(_writer.BaseStream.Position, tFlag);
            _writer.Write(GetStringIndex(tFlag));
        }
    }

    public override void Write(IRedHandle instance)
    {
        var target = instance.GetValue();

        if (_header.version == 2)
        {
            if (target != null)
            {
                InternalHandleWriter(target, 0, typeof(short));
            }
            else
            {
                BaseWriter.Write((short)-1);
            }
        }
        else if (_header.version == 03 || _header.version == 04)
        {
            if (target != null)
            {
                InternalHandleWriter(target, 0);
            }
            else
            {
                BaseWriter.Write(-1);
            }
        }
        else
        {
            throw new NotSupportedException(nameof(Write));
        }
    }

    public override void Write(IRedWeakHandle instance)
    {
        if (_header.version == 2)
        {
            InternalHandleWriter(instance.GetValue(), 0, typeof(short));
        }
        else if (_header.version == 03 || _header.version == 04)
        {
            InternalHandleWriter(instance.GetValue(), 0);
        }
        else
        {
            throw new NotSupportedException(nameof(Write));
        }
    }

    public override void Write(IRedResourceReference instance)
    {
        if (instance.DepotPath == ResourcePath.Empty)
        {
            _writer.Write((short)-1);
            return;
        }

        var val = new ImportEntry(CName.Empty, instance.DepotPath, (ushort)1);

        ImportRef.Add(_writer.BaseStream.Position, val);
        _writer.Write(GetImportIndex(val));
    }

    public override void Write(IRedResourceAsyncReference instance)
    {
        if (instance.DepotPath == ResourcePath.Empty)
        {
            _writer.Write((short)-1);
            return;
        }

        var val = new ImportEntry(CName.Empty, instance.DepotPath, (ushort)0);

        ImportRef.Add(_writer.BaseStream.Position, val);
        _writer.Write(GetImportIndex(val));
    }

    public override void Write(NodeRef val)
    {
        NotResolvableException.ThrowIfNotResolvable(val);

        var strBytes = Encoding.UTF8.GetBytes(val!);

        _writer.Write((short)strBytes.Length);
        _writer.Write(strBytes);
    }

    public override void Write(LocalizationString val)
    {
        var strBytes = Encoding.UTF8.GetBytes(val.Value);

        _writer.Write(val.Unk1);
        _writer.Write((short)strBytes.Length);
        _writer.Write(strBytes);
    }

    public override void Write(CString val)
    {
        var strBytes = Encoding.UTF8.GetBytes(val);

        _writer.Write((short)strBytes.Length);
        _writer.Write(strBytes);
    }

    public override void Write(TweakDBID val)
    {
        if (_header.version == 02 || _header.version == 03)
        {
            NotResolvableException.ThrowIfNotResolvable(val);

            _writer.Write((short)val.Length);
            _writer.Write(Encoding.UTF8.GetBytes(val!));
        }
        else if (_header.version == 04)
        {
            base.Write(val);
        }
        else
        {
            throw new NotSupportedException(nameof(Write));
        }
    }
}