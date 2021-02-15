using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePhysicalDestructionListenerComponent : entIComponent
	{
		[Ordinal(3)] [RED("physicalDestructionComponentName")] public CName PhysicalDestructionComponentName { get; set; }
		[Ordinal(4)] [RED("thresholdLevels")] public CArray<CFloat> ThresholdLevels { get; set; }

		public gamePhysicalDestructionListenerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
