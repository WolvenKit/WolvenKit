using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemTargetFilter_ClosestOpaque : gametargetingSystemTargetFilter_Closest
	{
		public gametargetingSystemTargetFilter_ClosestOpaque(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
