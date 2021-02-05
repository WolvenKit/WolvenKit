using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderMultilayerMaskBlob : IRenderResourceBlob
	{
		[Ordinal(0)]  [RED("header")] public rendRenderMultilayerMaskBlobHeader Header { get; set; }
		[Ordinal(1)]  [RED("atlasData")] public serializationDeferredDataBuffer AtlasData { get; set; }
		[Ordinal(2)]  [RED("tilesData")] public serializationDeferredDataBuffer TilesData { get; set; }

		public rendRenderMultilayerMaskBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
