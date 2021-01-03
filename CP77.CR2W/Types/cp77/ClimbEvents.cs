using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ClimbEvents : LocomotionGroundEvents
	{
		[Ordinal(0)]  [RED("ikHandEvents")] public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents { get; set; }
		[Ordinal(1)]  [RED("shouldIkHands")] public CBool ShouldIkHands { get; set; }

		public ClimbEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
