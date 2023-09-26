namespace WolvenKit.RED4.Types;

public partial class scnbSceneEffect : ISerializable
{
    [RED("id")]
    public scnbSceneEffectId Id
    {
        get => GetPropertyValue<scnbSceneEffectId>();
        set => SetPropertyValue<scnbSceneEffectId>(value);
    }

    [RED("name")]
    public CString Name
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [RED("effect")]
    public CResourceAsyncReference<worldEffect> Effect
    {
        get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
        set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
    }

    [RED("originMode")]
    public CUInt32 OriginMode
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    public scnbSceneEffect()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}