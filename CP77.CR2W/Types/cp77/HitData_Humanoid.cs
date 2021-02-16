using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitData_Humanoid : HitData_Base
	{
		[Ordinal(3)] [RED("reactionZonesSide")] public CEnum<ReactionZones_Humanoid_Side> ReactionZonesSide { get; set; }

		public HitData_Humanoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
