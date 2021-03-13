using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhysicalDestructionListenerComponent : entIComponent
	{
		[Ordinal(3)] [RED("physicalDestructionComponentName")] public CName PhysicalDestructionComponentName { get; set; }
		[Ordinal(4)] [RED("thresholdLevels")] public CArray<CFloat> ThresholdLevels { get; set; }

		public gamePhysicalDestructionListenerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
