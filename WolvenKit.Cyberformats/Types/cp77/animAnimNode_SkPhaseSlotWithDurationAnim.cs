using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseSlotWithDurationAnim : animAnimNode_SkPhaseWithDurationAnim
	{
		[Ordinal(32)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(33)] [RED("actionAnimDatabaseRef")] public rRef<animActionAnimDatabase> ActionAnimDatabaseRef { get; set; }

		public animAnimNode_SkPhaseSlotWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
