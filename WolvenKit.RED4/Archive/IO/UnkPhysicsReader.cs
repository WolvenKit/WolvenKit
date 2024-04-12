using System.Reflection;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using WolvenKit.RED4.Types.PhysicalScene;
using Activator = System.Activator;

namespace WolvenKit.RED4.Archive.IO;

public class UnkPhysicsReader : Red4Reader, IBufferReader
{
    public ILoggerService? LoggerService { get; set; }

    public UnkPhysicsReader(Stream input) : base(input)
    {
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var result = new UnkPhysicsBufferClass();
        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            result.Classes.Add(ReadPhysics());
        }

        buffer.Data = result;

        return EFileReadErrorCodes.NoError;
    }

    private physicsPhysicsBase ReadPhysics()
    {
        var baseType = (Enums.physicsEPhysicsBaseType)_reader.ReadByte();

        var item = baseType switch
        {
            Enums.physicsEPhysicsBaseType.Base => new physicsPhysicsBase(),
            Enums.physicsEPhysicsBaseType.Actor => new physicsPhysicsActor(),
            Enums.physicsEPhysicsBaseType.Shape => new physicsPhysicsShape(),
            Enums.physicsEPhysicsBaseType.Joint => new physicsPhysicsJoint(),
            Enums.physicsEPhysicsBaseType.Mesh => new physicsPhysicsMesh(),
            Enums.physicsEPhysicsBaseType.Max => throw new ArgumentOutOfRangeException(),
            _ => throw new ArgumentOutOfRangeException()
        };
        item.BaseType = baseType;

        ReadClass(item, 0);

        if (item is physicsPhysicsActor physicsActor)
        {
            for (var i = 0; i < physicsActor.Shapes.Count; i++)
            {
                var subItem = ReadPhysics();
                if (subItem is not physicsPhysicsShape physicsShape || physicsActor.PhysicsBaseId != physicsShape.ParentId)
                {
                    throw new Exception();
                }
                
                physicsActor.Shapes[i] = physicsShape;
            }
        }

        if (item is physicsPhysicsShape physicsShape2)
        {
            physicsShape2.Geometry = ReadShapeGeometry();
        }

        return item;
    }

    private physicsShapeGeometryBase ReadShapeGeometry()
    {
        var shapeType = (Enums.physicsEPhysicsShapeGeometryType)_reader.ReadByte();

        physicsShapeGeometryBase item = shapeType switch
        {
            Enums.physicsEPhysicsShapeGeometryType.Box => new physicsShapeGeometryBox(),
            Enums.physicsEPhysicsShapeGeometryType.Sphere => new physicsShapeGeometrySphere(),
            Enums.physicsEPhysicsShapeGeometryType.Capsule => new physicsShapeGeometryCapsule(),
            Enums.physicsEPhysicsShapeGeometryType.Convex => new physicsShapeGeometryConvex(),
            Enums.physicsEPhysicsShapeGeometryType.TriMesh => new physicsShapeGeometryTriMesh(),
            Enums.physicsEPhysicsShapeGeometryType.Invalid => throw new ArgumentOutOfRangeException(),
            Enums.physicsEPhysicsShapeGeometryType.Max => throw new ArgumentOutOfRangeException(),
            _ => throw new ArgumentOutOfRangeException()
        };
        item.ShapeType = shapeType;

        ReadClass(item, 0);

        return item;
    }

    public override void ReadClass(RedBaseClass cls, uint size)
    {
        var zero = _reader.ReadByte();
        if (zero != 0)
        {
            throw new Exception($"Tried parsing a CVariable: zero read {zero}.");
        }

        var typeInfo = RedReflection.GetTypeInfo(cls);

        while (true)
        {
            var cVar = ReadVariable(cls, typeInfo);
            if (!cVar)
            {
                return;
            }
        }
    }

    private bool ReadVariable(RedBaseClass cls, ExtendedTypeInfo typeInfo)
    {
        var varName = _reader.ReadLengthPrefixedString();
        if (varName == "None")
        {
            return false;
        }

        var redTypeName = _reader.ReadLengthPrefixedString();
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
                // Patch for non-updated base files...
                if (fullName == "physicsPhysicsShape.material" && TryReadValue(redTypeName, size, out value))
                {
                    SetProperty(cls, prop.RedName, ((physicsMaterialReference)value!).Name);
                    return true;
                }
            }

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

            _reader.BaseStream.Position = dataStartPos;

            if (propRedType == redTypeName)
            {
                LoggerService?.Warning($"Can't read data for \"{fullName}\" (\"{propRedType}\"). Skipping");

                _reader.BaseStream.Position += size;
                return true;
            }

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

            LoggerService?.Warning($"Invalid RedType detected for \"{fullName}\". \"{redTypeName}\" instead of \"{propRedType}\". Skipping");

            _reader.BaseStream.Position += size;
            return true;
        }

        // dynamic stuff
        var redTypeInfos = RedReflection.GetRedTypeInfos(redTypeName);
        var (hasError, errorRedName) = CheckRedTypeInfos(ref redTypeInfos);

        if (hasError)
        {
            LoggerService?.Warning($"Type \"{errorRedName}\" is not known! Non-RTTI property \"{fullName}\" will be ignored");

            _reader.BaseStream.Position = dataStartPos + size;
            return true;
        }

        var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);

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

    private void SetProperty(RedBaseClass cls, string varName, IRedType? value) => cls.SetProperty(varName, value);

    public override IRedResourceReference ReadCResourceReference(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        ResourcePath depotPath;
        if (size == 8)
        {
            depotPath = (ResourcePath)_reader.ReadUInt64();
        }
        else // Patch for non-updated base files...
        {
            depotPath = (ResourcePath)_reader.ReadLengthPrefixedString();
        }

        var flags = InternalEnums.EImportFlags.Default;

        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type, depotPath, flags) is not IRedResourceReference result)
        {
            throw new Exception();
        }

        return result;
    }

    public override IRedEnum ReadCEnum(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 1)
        {
            throw new TodoException();
        }

        var value = _reader.ReadLengthPrefixedString();

        var enumInfo = RedReflection.GetEnumTypeInfo(redTypeInfos[0].RedObjectType);
        var enumString = enumInfo.GetCSNameFromRedName(value!);

        object? enumValue = null;
        if (enumString != null)
        {
            enumValue = Enum.Parse(redTypeInfos[0].RedObjectType, enumString);
        }
        if (enumString == null)
        {
            var args = new InvalidEnumValueEventArgs(redTypeInfos[0].RedObjectType, value!);
            if (!HandleParsingError(args))
            {
                throw new Exception($"CEnum \"{redTypeInfos[0].RedObjectType.Name}.{value}\" could not be found!");
            }

            enumValue = args.Value;
        }

        var type = RedReflection.GetFullType(redTypeInfos);

        if (Activator.CreateInstance(type, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { enumValue }, null) is not IRedEnum result)
        {
            throw new Exception();
        }

        return result;
    }

    public override CName ReadCName() => _reader.ReadLengthPrefixedString();
}

public class UnkPhysicsBufferClass : IParseableBuffer
{
    public IRedType? Data { get; }

    public CArray<physicsPhysicsBase> Classes { get; set; } = new();
}