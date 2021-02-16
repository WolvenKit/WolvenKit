using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ClimbEvents : LocomotionGroundEvents
	{
		[Ordinal(0)] [RED("ikHandEvents")] public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents { get; set; }
		[Ordinal(1)] [RED("shouldIkHands")] public CBool ShouldIkHands { get; set; }

		public ClimbEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
