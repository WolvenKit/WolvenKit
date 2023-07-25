using System.Text;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
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
            prop = cls.AddDynamicProperty(varName!, type);
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

            if (!typeInfo.SerializeDefault && !prop.SerializeDefault && prop.IsDefault(value))
            {
                var args = new InvalidDefaultValueEventArgs();
                if (!HandleParsingError(args))
                {
                    throw new InvalidParsingException($"Invalid default val for: \"{propName}\"");
                }
            }

            cls.SetProperty(prop.RedName, value);
        }

        PostProcess(value);

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

        return true;

        void PostProcess(IRedType? internalValue)
        {
            if (internalValue is IRedBufferPointer buf)
            {
                buf.GetValue().ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                buf.GetValue().Parent = cls;
            }

            if (internalValue is SharedDataBuffer shared)
            {
                shared.Buffer.ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                shared.Buffer.Parent = cls;

                ParseBuffer(shared.Buffer);
            }

            if (internalValue is IRedArray arr)
            {
                foreach (IRedType entry in arr)
                {
                    PostProcess(entry);
                }
            }
        }
    }
}