using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCableMeshNode : worldBendedMeshNode
	{
		[Ordinal(0)]  [RED("cableLength")] public CFloat CableLength { get; set; }
		[Ordinal(1)]  [RED("cableRadius")] public CFloat CableRadius { get; set; }
		[Ordinal(2)]  [RED("destructionHashes", 2)] public CArrayFixedSize<CUInt64> DestructionHashes { get; set; }

		public worldCableMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
