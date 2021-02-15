using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAcousticSectorNode : worldNode
	{
		[Ordinal(2)] [RED("data")] public raRef<worldAcousticDataResource> Data { get; set; }
		[Ordinal(3)] [RED("inSectorCoordsX")] public CUInt32 InSectorCoordsX { get; set; }
		[Ordinal(4)] [RED("inSectorCoordsY")] public CUInt32 InSectorCoordsY { get; set; }
		[Ordinal(5)] [RED("inSectorCoordsZ")] public CUInt32 InSectorCoordsZ { get; set; }
		[Ordinal(6)] [RED("generatorId")] public CUInt32 GeneratorId { get; set; }
		[Ordinal(7)] [RED("edgeMask")] public CUInt8 EdgeMask { get; set; }

		public worldAcousticSectorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
