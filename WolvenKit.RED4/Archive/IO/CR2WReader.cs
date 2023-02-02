using System.Text;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public partial class CR2WReader : Red4Reader
{
    public ILoggerService? LoggerService { get; set; }

    public CR2WReader(Stream input) : this(input, Encoding.UTF8, false)
    {
    }

    public CR2WReader(Stream input, Encoding encoding) : this(input, encoding, false)
    {
    }

    public CR2WReader(Stream input, Encoding encoding, bool leaveOpen) : this(new BinaryReader(input, encoding, leaveOpen))
    {
    }

    public CR2WReader(BinaryReader reader) : base(reader)
    {
    }

    public override void ReadClass(RedBaseClass cls, uint size)
    {
        if (cls is IRedCustomData customCls)
        {
            customCls.CustomRead(this, size);
            return;
        }

        var startpos = _reader.BaseStream.Position;

        #region initial checks

        // ... okay CDPR, is that a joke or what?
        int zero = _reader.ReadByte();
        if (zero != 0)
        {
            throw new Exception($"Tried parsing a CVariable: zero read {zero}.");
        }

        #endregion

        #region parse sequential variables
        while (true)
        {
            var cvar = ReadVariable(cls);
            if (!cvar)
            {
                break;
            }
        }
        #endregion

        var endpos = _reader.BaseStream.Position;
        var bytesread = endpos - startpos;

        if (cls is IRedAppendix app)
        {
            app.Read(this, (uint)(size - bytesread));
        }

        if (bytesread != size)
        {
            //throw new InvalidParsingException($"Read bytes not equal to expected bytes. Difference: {bytesread - size}");
        }
    }

    public bool ReadVariable(RedBaseClass cls)
    {
        var nameId = _reader.ReadUInt16();
        if (nameId == 0)
        {
            return false;
        }
        var varName = GetStringValue(nameId);

        // Read Type
        var typeId = _reader.ReadUInt16();
        var typename = GetStringValue(typeId);

        // Read Size
        var sizepos = _reader.BaseStream.Position;
        var size = _reader.ReadUInt32();

        var (type, flags) = RedReflection.GetCSTypeFromRedType(typename!);
        var redTypeInfos = RedReflection.GetRedTypeInfos(typename!);
        CheckRedTypeInfos(ref redTypeInfos);

        var typeInfo = RedReflection.GetTypeInfo(cls);

        IRedType? value;
        var prop = RedReflection.GetPropertyByRedName(cls.GetType(), varName!);
        if (prop == null)
        {
            prop = typeInfo.AddDynamicProperty(varName!, typename!);
        }

        if (prop.IsDynamic)
        {
            value = Read(redTypeInfos, size - 4);

            cls.SetProperty(varName!, value);
        }
        else
        {
            ArgumentNullException.ThrowIfNull(prop.RedName);

            value = Read(redTypeInfos, size - 4);

            var propName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";
            if (type != prop.Type)
            {
                var args = new InvalidRTTIEventArgs(propName, prop.Type, type, value);
                if (!HandleParsingError(args))
                {
                    throw new InvalidRTTIException(propName, prop.Type, type);
                }
                value = args.Value;
            }

            if (!typeInfo.SerializeDefault && !prop.SerializeDefault && RedReflection.IsDefault(cls.GetType(), varName!, value))
            {
                var args = new InvalidDefaultValueEventArgs();
                if (!HandleParsingError(args))
                {
                    throw new InvalidParsingException($"Invalid default val for: \"{propName}\"");
                }
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

                if (value is CName { IsResolvable: true } str2)
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

        PostProcess();

        return true;

        void PostProcess()
        {
            if (value is IRedBufferPointer buf)
            {
                buf.GetValue().ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                buf.GetValue().Parent = cls;
            }

            if (value is IRedArray arr)
            {
                if (typeof(IRedBufferPointer).IsAssignableFrom(arr.InnerType))
                {
                    foreach (IRedBufferPointer entry in arr)
                    {
                        entry.GetValue().ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                        entry.GetValue().Parent = cls;
                    }
                }
            }
        }
    }

    public override SharedDataBuffer ReadSharedDataBuffer(uint size)
    {
        var innerSize = BaseReader.ReadUInt32();
        if (size != innerSize + 4)
        {
            throw new TodoException("ReadSharedDataBuffer");
        }

        var result = base.ReadSharedDataBuffer(innerSize);

        if (_parseBuffer)
        {
            using var ms = new MemoryStream(result.Buffer.GetBytes());
            using var br = new BinaryReader(ms, Encoding.Default, true);

            using var cr2wReader = new CR2WReader(br);
            cr2wReader.ParsingError += HandleParsingError;

            var readResult = cr2wReader.ReadFile(out var c, true);
            if (readResult == EFileReadErrorCodes.NoCr2w)
            {
                throw new TodoException("ReadSharedDataBuffer");
            }

            result.File = c;
        }

        return result;
    }

    public override IRedHandle? ReadCHandle<T>()
    {
        var pointer = _reader.ReadInt32() - 1;
        if (pointer < 0)
        {
            return null;
        }

        return new CHandle<T>((T)_chunks[pointer]);
    }

    public override IRedHandle? ReadCHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var pointer = _reader.ReadInt32() - 1;
        if (pointer < 0)
        {
            return null;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (System.Activator.CreateInstance(type, _chunks[pointer]) is not IRedHandle result)
        {
            throw new Exception();
        }

        return result;
    }

    public override IRedWeakHandle? ReadCWeakHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var pointer = _reader.ReadInt32() - 1;
        if (pointer < 0)
        {
            return null;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (System.Activator.CreateInstance(type, _chunks[pointer]) is not IRedWeakHandle result)
        {
            throw new Exception();
        }

        return result;
    }
}