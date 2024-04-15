namespace WolvenKit.RED4.Types;

public partial class inkTextureAtlas
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
            "activeTexture", 
            "dynamicTexture", 
            "parts", 
            "slices", 
            "texture"
        ]);
    }
}

