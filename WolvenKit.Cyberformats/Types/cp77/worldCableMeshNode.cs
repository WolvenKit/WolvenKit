using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCableMeshNode : worldBendedMeshNode
	{
		[Ordinal(13)] [RED("destructionHashes", 2)] public CArrayFixedSize<CUInt64> DestructionHashes { get; set; }
		[Ordinal(14)] [RED("cableLength")] public CFloat CableLength { get; set; }
		[Ordinal(15)] [RED("cableRadius")] public CFloat CableRadius { get; set; }

		public worldCableMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
