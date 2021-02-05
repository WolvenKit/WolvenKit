using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SwimmingClimbEvents : ClimbEvents
	{
		[Ordinal(0)]  [RED("ikHandEvents")] public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents { get; set; }
		[Ordinal(1)]  [RED("shouldIkHands")] public CBool ShouldIkHands { get; set; }

		public SwimmingClimbEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
