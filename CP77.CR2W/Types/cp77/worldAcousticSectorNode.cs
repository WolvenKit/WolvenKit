using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldAcousticSectorNode : worldNode
	{
		[Ordinal(0)]  [RED("data")] public raRef<worldAcousticDataResource> Data { get; set; }
		[Ordinal(1)]  [RED("edgeMask")] public CUInt8 EdgeMask { get; set; }
		[Ordinal(2)]  [RED("generatorId")] public CUInt32 GeneratorId { get; set; }
		[Ordinal(3)]  [RED("inSectorCoordsX")] public CUInt32 InSectorCoordsX { get; set; }
		[Ordinal(4)]  [RED("inSectorCoordsY")] public CUInt32 InSectorCoordsY { get; set; }
		[Ordinal(5)]  [RED("inSectorCoordsZ")] public CUInt32 InSectorCoordsZ { get; set; }

		public worldAcousticSectorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
