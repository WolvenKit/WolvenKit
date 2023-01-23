namespace WolvenKit.RED4.Types;

public enum BaseRedType
{
    Name = 0,
    Fundamental = 1,
    Class = 2,
    Array = 3,
    Simple = 4,
    Enum = 5,
    StaticArray = 6,
    NativeArray = 7,
    Pointer = 8,
    Handle = 9,
    WeakHandle = 10,
    ResourceReference = 11,
    ResourceAsyncReference = 12,
    BitField = 13,
    LegacySingleChannelCurve = 14,
    ScriptReference = 15,
    FixedArray = 16,

    Special = 99
}

public enum SimpleRedType
{
    CName,
    String,
    LocalizationString,
    TweakDBID,
    DataBuffer,
    serializationDeferredDataBuffer,
    SharedDataBuffer,
    Variant,
    CDateTime,
    CGUID,
    CRUID,
    CRUIDRef,
    EditorObjectID,
    gamedataLocKeyWrapper,
    MessageResourcePath,
    NodeRef,
    RuntimeEntityRef
}

public enum FundamentalRedType
{
    Bool,
    Int8,
    Uint8,
    Int16,
    Uint16,
    Int32,
    Uint32,
    Int64,
    Uint64,
    Float,
    Double
}

public enum SpecialRedType
{
    MultiChannelCurve,

    // enum/bitfield/class
    Mixed
}


public class RedTypeInfo
{
    public BaseRedType BaseRedType { get; set; }

    public Type RedObjectType { get; set; }
    public string RedObjectName { get; set; }

    public Type MappedType => GetTypeMapping();
    public int ArrayCount { get; set; }

    public RedTypeInfo(BaseRedType baseRedType, int arrayCount = -1)
    {
        BaseRedType = baseRedType;
        ArrayCount = arrayCount;
    }

    public RedTypeInfo(BaseRedType baseRedType, string redObjectName)
    {
        BaseRedType = baseRedType;

        RedObjectName = redObjectName;

        ArrayCount = -1;
    }

    public RedTypeInfo(BaseRedType baseRedType, Type redObjectType)
    {
        BaseRedType = baseRedType;

        RedObjectType = redObjectType;
        RedObjectName = redObjectType.Name;

        ArrayCount = -1;
    }

    protected virtual Type GetTypeMapping()
    {
        switch (BaseRedType)
        {
            case BaseRedType.Class:
                return typeof(RedBaseClass);
            case BaseRedType.Array:
                return typeof(CArray<>);
            case BaseRedType.Enum:
                return typeof(CEnum<>);
            case BaseRedType.StaticArray:
                return typeof(CStatic<>);
            case BaseRedType.NativeArray:
                return typeof(CArrayFixedSize<>);
            case BaseRedType.Handle:
                return typeof(CHandle<>);
            case BaseRedType.WeakHandle:
                return typeof(CWeakHandle<>);
            case BaseRedType.ResourceReference:
                return typeof(CResourceReference<>);
            case BaseRedType.ResourceAsyncReference:
                return typeof(CResourceAsyncReference<>);
            case BaseRedType.BitField:
                return typeof(CBitField<>);
            case BaseRedType.LegacySingleChannelCurve:
                return typeof(CLegacySingleChannelCurve<>);
            default:
                throw new NotImplementedException(BaseRedType.ToString());
        }
    }
}

public class SimpleRedTypeInfo : RedTypeInfo
{
    public SimpleRedType SimpleRedType { get; set; }

    public SimpleRedTypeInfo(SimpleRedType simpleRedType) : base(BaseRedType.Simple)
    {
        SimpleRedType = simpleRedType;
    }

    protected override Type GetTypeMapping()
    {
        switch (SimpleRedType)
        {
            case SimpleRedType.CName:
                return typeof(CName);
            case SimpleRedType.String:
                return typeof(CString);
            case SimpleRedType.LocalizationString:
                return typeof(LocalizationString);
            case SimpleRedType.TweakDBID:
                return typeof(TweakDBID);
            case SimpleRedType.DataBuffer:
                return typeof(DataBuffer);
            case SimpleRedType.serializationDeferredDataBuffer:
                return typeof(SerializationDeferredDataBuffer);
            case SimpleRedType.SharedDataBuffer:
                return typeof(SharedDataBuffer);
            case SimpleRedType.Variant:
                return typeof(CVariant);
            case SimpleRedType.CDateTime:
                return typeof(CDateTime);
            case SimpleRedType.CGUID:
                return typeof(CGuid);
            case SimpleRedType.CRUID:
                return typeof(CRUID);
            case SimpleRedType.EditorObjectID:
                return typeof(EditorObjectID);
            case SimpleRedType.gamedataLocKeyWrapper:
                return typeof(gamedataLocKeyWrapper);
            case SimpleRedType.MessageResourcePath:
                return typeof(MessageResourcePath);
            case SimpleRedType.NodeRef:
                return typeof(NodeRef);
            default:
                throw new NotImplementedException(SimpleRedType.ToString());
        }
    }
}

public class FundamentalRedTypeInfo : RedTypeInfo
{
    public FundamentalRedType FundamentalRedType { get; set; }

    public FundamentalRedTypeInfo(FundamentalRedType fundamentalRedType) : base(BaseRedType.Fundamental)
    {
        FundamentalRedType = fundamentalRedType;
    }

    protected override Type GetTypeMapping()
    {
        switch (FundamentalRedType)
        {
            case FundamentalRedType.Bool:
                return typeof(CBool);
            case FundamentalRedType.Int8:
                return typeof(CInt8);
            case FundamentalRedType.Uint8:
                return typeof(CUInt8);
            case FundamentalRedType.Int16:
                return typeof(CInt16);
            case FundamentalRedType.Uint16:
                return typeof(CUInt16);
            case FundamentalRedType.Int32:
                return typeof(CInt32);
            case FundamentalRedType.Uint32:
                return typeof(CUInt32);
            case FundamentalRedType.Int64:
                return typeof(CInt64);
            case FundamentalRedType.Uint64:
                return typeof(CUInt64);
            case FundamentalRedType.Float:
                return typeof(CFloat);
            case FundamentalRedType.Double:
                return typeof(CDouble);
            default:
                throw new ArgumentOutOfRangeException(FundamentalRedType.ToString());
        }
    }
}

public class SpecialRedTypeInfo : RedTypeInfo
{
    public SpecialRedType SpecialRedType { get; set; }
    public string RedName { get; set; }

    public SpecialRedTypeInfo(SpecialRedType specialRedType, string redName = null) : base(BaseRedType.Special)
    {
        SpecialRedType = specialRedType;
        RedName = redName;
    }

    protected override Type GetTypeMapping()
    {
        switch (SpecialRedType)
        {
            case SpecialRedType.MultiChannelCurve:
                return typeof(MultiChannelCurve<>);
            case SpecialRedType.Mixed:
                return null;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
