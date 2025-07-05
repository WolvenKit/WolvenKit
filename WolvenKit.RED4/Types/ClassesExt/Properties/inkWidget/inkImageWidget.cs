namespace WolvenKit.RED4.Types;

public partial class inkImageWidget : inkIImageWidget
{

}

public partial class inkMaskWidget : inkIImageWidget
{

}

public interface inkIImageWidget
{
    public CResourceAsyncReference<inkTextureAtlas> TextureAtlas { get; set; }

    public CName TexturePart { get; set; }
}
