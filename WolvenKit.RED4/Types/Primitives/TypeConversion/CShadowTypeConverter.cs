namespace WolvenKit.RED4.Types.TypeConversion;

public class CShadowTypeConverter : IRedType
{
    private CEnum<Enums.shadowsShadowCastingMode> enumValue;

    public CShadowTypeConverter(CEnum<Enums.shadowsShadowCastingMode> value)
    {
        enumValue = value;
    }

    public CShadowTypeConverter(CBool boolValue)
    {
        enumValue = boolValue ? Enums.shadowsShadowCastingMode.Always : Enums.shadowsShadowCastingMode.Never;
    }

    public CEnum<Enums.shadowsShadowCastingMode> value
    {
        get => enumValue;
        set => enumValue = value;
    }
}