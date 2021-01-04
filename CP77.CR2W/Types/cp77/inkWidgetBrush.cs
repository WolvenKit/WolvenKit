using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBrush : IScriptable
	{
		[Ordinal(0)]  [RED("mirrorType")] public CEnum<inkBrushMirrorType> MirrorType { get; set; }
		[Ordinal(1)]  [RED("textureAtlas")] public rRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(2)]  [RED("texturePartId")] public CName TexturePartId { get; set; }
		[Ordinal(3)]  [RED("tileType")] public CEnum<inkBrushTileType> TileType { get; set; }

		public inkWidgetBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
