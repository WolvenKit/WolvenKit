using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkMaskWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("dataSource")] public CEnum<inkMaskDataSource> DataSource { get; set; }
		[Ordinal(1)]  [RED("dynamicTextureMask")] public CName DynamicTextureMask { get; set; }
		[Ordinal(2)]  [RED("invertMask")] public CBool InvertMask { get; set; }
		[Ordinal(3)]  [RED("maskTransparency")] public CFloat MaskTransparency { get; set; }
		[Ordinal(4)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(5)]  [RED("texturePart")] public CName TexturePart { get; set; }

		public inkMaskWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
