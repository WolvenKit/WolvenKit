using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownGrapplePreyEvents : LocomotionTakedownEvents
	{
		private CBool _isGrappleReactionVOPlayed;

		[Ordinal(4)] 
		[RED("isGrappleReactionVOPlayed")] 
		public CBool IsGrappleReactionVOPlayed
		{
			get => GetProperty(ref _isGrappleReactionVOPlayed);
			set => SetProperty(ref _isGrappleReactionVOPlayed, value);
		}
	}
}
