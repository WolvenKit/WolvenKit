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

        var typeInfo = RedReflection.GetTypeInfo(cls);

        #region parse sequential variables
        while (true)
        {
            var cVar = ReadVariable(cls, typeInfo);
            if (!cVar)
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

    public bool ReadVariable(RedBaseClass cls, ExtendedTypeInfo typeInfo)
    {
        var varCName = ReadCName();
        if (varCName == CName.Empty)
        {
            return false;
        }
        var varName = varCName.GetResolvedText()!;

        var redTypeName = ReadCName();
        var size = _reader.ReadUInt32() - 4;

        var dataStartPos = _reader.BaseStream.Position;

        var fullName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";

        IRedType? value;

        var prop = RedReflection.GetPropertyByRedName(cls.GetType(), varName);
        if (prop != null)
        {
            ArgumentNullException.ThrowIfNull(prop.RedName);

            var propRedType = RedReflection.GetRedTypeFromCSType(prop.Type, prop.Flags);

            if (propRedType != redTypeName)
            {
                if (TryReadValue(redTypeName!, size, out value))
                {
                    var args = new InvalidRTTIEventArgs(fullName, propRedType, redTypeName, value);
                    if (!HandleParsingError(args))
                    {
                        throw new InvalidRTTIException(fullName, propRedType, redTypeName);
                    }

                    SetProperty(cls, prop.RedName, args.Value);
                    return true;
                }
            }

            _reader.BaseStream.Position = dataStartPos;

            if (TryReadValue(propRedType, size, out value))
            {
                if (!typeInfo.SerializeDefault && !prop.SerializeDefault && prop.IsDefault(value))
                {
                    var args = new InvalidDefaultValueEventArgs();
                    if (!HandleParsingError(args))
                    {
                        throw new InvalidParsingException($"Invalid default val for: \"{fullName}\"");
                    }
                }

                SetProperty(cls, prop.RedName, value);
                return true;
            }

            _reader.BaseStream.Position = dataStartPos + size;

            if (propRedType == redTypeName)
            {
                LoggerService?.Warning($"Can't read data for \"{fullName}\" (\"{propRedType}\"). Skipping");
                return true;
            }

            LoggerService?.Warning($"Invalid RedType detected for \"{fullName}\". \"{redTypeName}\" instead of \"{propRedType}\". Skipping");
            return true;
        }

        // dynamic stuff
        var redTypeInfos = RedReflection.GetRedTypeInfos(redTypeName!);
        var (hasError, errorRedName) = CheckRedTypeInfos(ref redTypeInfos);
        
        if (hasError)
        {
            LoggerService?.Warning($"Type \"{errorRedName}\" is not known! Non-RTTI property \"{fullName}\" will be ignored");

            _reader.BaseStream.Position = dataStartPos + size;
            return true;
        }

        var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName!);
        
        cls.AddDynamicProperty(varName, type);
        value = Read(redTypeInfos, size);
        SetProperty(cls, varName, value);

        return true;
    }

    private bool TryReadValue(string redTypeName, uint size, out IRedType? value)
    {
        try
        {
            var redTypeInfos = RedReflection.GetRedTypeInfos(redTypeName);
            value = Read(redTypeInfos, size);

            return true;
        }
        catch (Exception)
        {
            value = null;
            return false;
        }
    }

    private void SetProperty(RedBaseClass cls, string varName, IRedType? value)
    {
        cls.SetProperty(varName, value);
        PostProcess(value);

        if (!CollectData)
        {
            return;
        }

        if (varName.Contains("Fact", StringComparison.InvariantCultureIgnoreCase) && !varName.Contains("Factor", StringComparison.InvariantCultureIgnoreCase))
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