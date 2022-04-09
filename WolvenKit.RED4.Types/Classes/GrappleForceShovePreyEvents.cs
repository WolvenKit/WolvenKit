using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrappleForceShovePreyEvents : LocomotionTakedownEvents
	{
		[Ordinal(7)] 
		[RED("unmountCalled")] 
		public CBool UnmountCalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GrappleForceShovePreyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
