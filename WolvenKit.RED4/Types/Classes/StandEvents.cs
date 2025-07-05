using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StandEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("enteredAfterSprintWithNoInput")] 
		public CBool EnteredAfterSprintWithNoInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
