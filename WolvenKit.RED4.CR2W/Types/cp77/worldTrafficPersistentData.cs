using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentData : CVariable
	{
		[Ordinal(0)] [RED("lanes")] public CArray<worldTrafficLanePersistent> Lanes { get; set; }
		[Ordinal(1)] [RED("neighborGroups")] public CArray<CArray<CUInt16>> NeighborGroups { get; set; }

		public worldTrafficPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
