using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMaskWidget : inkLeafWidget
	{
		[Ordinal(20)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(21)] [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(22)] [RED("dynamicTextureMask")] public CName DynamicTextureMask { get; set; }
		[Ordinal(23)] [RED("dataSource")] public CEnum<inkMaskDataSource> DataSource { get; set; }
		[Ordinal(24)] [RED("invertMask")] public CBool InvertMask { get; set; }
		[Ordinal(25)] [RED("maskTransparency")] public CFloat MaskTransparency { get; set; }

		public inkMaskWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
