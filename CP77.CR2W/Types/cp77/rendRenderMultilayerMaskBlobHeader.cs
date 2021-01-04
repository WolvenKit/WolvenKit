using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderMultilayerMaskBlobHeader : CVariable
	{
		[Ordinal(0)]  [RED("atlasHeight")] public CUInt32 AtlasHeight { get; set; }
		[Ordinal(1)]  [RED("atlasWidth")] public CUInt32 AtlasWidth { get; set; }
		[Ordinal(2)]  [RED("flags")] public CUInt32 Flags { get; set; }
		[Ordinal(3)]  [RED("maskHeight")] public CUInt32 MaskHeight { get; set; }
		[Ordinal(4)]  [RED("maskHeightLow")] public CUInt32 MaskHeightLow { get; set; }
		[Ordinal(5)]  [RED("maskTileSize")] public CUInt32 MaskTileSize { get; set; }
		[Ordinal(6)]  [RED("maskWidth")] public CUInt32 MaskWidth { get; set; }
		[Ordinal(7)]  [RED("maskWidthLow")] public CUInt32 MaskWidthLow { get; set; }
		[Ordinal(8)]  [RED("numLayers")] public CUInt32 NumLayers { get; set; }
		[Ordinal(9)]  [RED("version")] public CUInt32 Version { get; set; }

		public rendRenderMultilayerMaskBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
