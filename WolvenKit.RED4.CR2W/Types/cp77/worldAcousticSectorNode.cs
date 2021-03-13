using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticSectorNode : worldNode
	{
		[Ordinal(4)] [RED("data")] public raRef<worldAcousticDataResource> Data { get; set; }
		[Ordinal(5)] [RED("inSectorCoordsX")] public CUInt32 InSectorCoordsX { get; set; }
		[Ordinal(6)] [RED("inSectorCoordsY")] public CUInt32 InSectorCoordsY { get; set; }
		[Ordinal(7)] [RED("inSectorCoordsZ")] public CUInt32 InSectorCoordsZ { get; set; }
		[Ordinal(8)] [RED("generatorId")] public CUInt32 GeneratorId { get; set; }
		[Ordinal(9)] [RED("edgeMask")] public CUInt8 EdgeMask { get; set; }

		public worldAcousticSectorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
