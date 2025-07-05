using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClimbDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ClimbDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
