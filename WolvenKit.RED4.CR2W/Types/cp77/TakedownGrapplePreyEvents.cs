using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakedownGrapplePreyEvents : LocomotionTakedownEvents
	{
		private CBool _isGrappleReactionVOPlayed;

		[Ordinal(1)] 
		[RED("isGrappleReactionVOPlayed")] 
		public CBool IsGrappleReactionVOPlayed
		{
			get => GetProperty(ref _isGrappleReactionVOPlayed);
			set => SetProperty(ref _isGrappleReactionVOPlayed, value);
		}

		public TakedownGrapplePreyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
