using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMaskWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("maskTransparency")] public CFloat MaskTransparency { get; set; }
		[Ordinal(1)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(2)]  [RED("dynamicTextureMask")] public CName DynamicTextureMask { get; set; }
		[Ordinal(3)]  [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(4)]  [RED("dataSource")] public CEnum<inkMaskDataSource> DataSource { get; set; }
		[Ordinal(5)]  [RED("invertMask")] public CBool InvertMask { get; set; }

		public inkMaskWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
