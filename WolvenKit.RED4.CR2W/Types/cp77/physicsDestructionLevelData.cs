using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionLevelData : CVariable
	{
		[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)] [RED("fracturingEffect")] public raRef<worldEffect> FracturingEffect { get; set; }

		public physicsDestructionLevelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
