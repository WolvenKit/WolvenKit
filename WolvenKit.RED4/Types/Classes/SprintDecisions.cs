using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SprintDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("sprintPressed")] 
		public CBool SprintPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("toggleSprintPressed")] 
		public CBool ToggleSprintPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SprintDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
