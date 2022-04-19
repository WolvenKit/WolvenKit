using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TakedownGrapplePreyEvents : LocomotionTakedownEvents
	{
		[Ordinal(7)] 
		[RED("isGrappleReactionVOPlayed")] 
		public CBool IsGrappleReactionVOPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TakedownGrapplePreyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
