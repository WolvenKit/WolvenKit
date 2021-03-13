using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakedownGrapplePreyEvents : LocomotionTakedownEvents
	{
		[Ordinal(1)] [RED("isGrappleReactionVOPlayed")] public CBool IsGrappleReactionVOPlayed { get; set; }

		public TakedownGrapplePreyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
