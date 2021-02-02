using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkImageWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(1)]  [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(2)]  [RED("contentHAlign")] public CEnum<inkEHorizontalAlign> ContentHAlign { get; set; }
		[Ordinal(3)]  [RED("contentVAlign")] public CEnum<inkEVerticalAlign> ContentVAlign { get; set; }
		[Ordinal(4)]  [RED("mirrorType")] public CEnum<inkBrushMirrorType> MirrorType { get; set; }
		[Ordinal(5)]  [RED("tileType")] public CEnum<inkBrushTileType> TileType { get; set; }
		[Ordinal(6)]  [RED("useNineSliceScale")] public CBool UseNineSliceScale { get; set; }
		[Ordinal(7)]  [RED("nineSliceScale")] public inkMargin NineSliceScale { get; set; }
		[Ordinal(8)]  [RED("tileHAlign")] public CEnum<inkEHorizontalAlign> TileHAlign { get; set; }
		[Ordinal(9)]  [RED("tileVAlign")] public CEnum<inkEVerticalAlign> TileVAlign { get; set; }

		public inkImageWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
