namespace WolvenKit.RED4.Types;

public partial class appearanceAppearanceResource
{
    public override IEnumerable<string> GetHiddenIfDefaultFieldNames()
    {
        return base.GetHiddenIfDefaultFieldNames().Concat(["censorshipMapping"]);
    }

    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
                "alternateAppearanceMapping",
                "alternateAppearanceSettingName",
                "alternateAppearanceSuffixes",
                "baseEntity",
                "baseEntityType",
                "baseType",
                "DismEffects",
                "DismWoundConfig",
                "forceCompileProxy",
                "generatePlayerBlockingCollisionForProxy",
                "proxyPolyCount",
                "Wounds",
            ]);
    }
}