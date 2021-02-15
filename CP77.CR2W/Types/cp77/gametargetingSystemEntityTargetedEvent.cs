using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemEntityTargetedEvent : redEvent
	{
		[Ordinal(0)] [RED("targetingEntity")] public wCHandle<entEntity> TargetingEntity { get; set; }

		public gametargetingSystemEntityTargetedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
