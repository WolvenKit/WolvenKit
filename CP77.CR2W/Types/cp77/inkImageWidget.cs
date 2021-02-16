using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkImageWidget : inkLeafWidget
	{
		[Ordinal(20)] [RED("useNineSliceScale")] public CBool UseNineSliceScale { get; set; }
		[Ordinal(21)] [RED("nineSliceScale")] public inkMargin NineSliceScale { get; set; }
		[Ordinal(22)] [RED("mirrorType")] public CEnum<inkBrushMirrorType> MirrorType { get; set; }
		[Ordinal(23)] [RED("tileType")] public CEnum<inkBrushTileType> TileType { get; set; }
		[Ordinal(24)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(25)] [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(26)] [RED("contentHAlign")] public CEnum<inkEHorizontalAlign> ContentHAlign { get; set; }
		[Ordinal(27)] [RED("contentVAlign")] public CEnum<inkEVerticalAlign> ContentVAlign { get; set; }
		[Ordinal(28)] [RED("tileHAlign")] public CEnum<inkEHorizontalAlign> TileHAlign { get; set; }
		[Ordinal(29)] [RED("tileVAlign")] public CEnum<inkEVerticalAlign> TileVAlign { get; set; }

		public inkImageWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
