using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DodgeDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("shouldDisableEnterCondition")] 
		public CBool ShouldDisableEnterCondition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DodgeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
