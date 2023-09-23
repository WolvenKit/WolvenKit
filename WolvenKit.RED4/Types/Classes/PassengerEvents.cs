using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassengerEvents : VehicleEventsTransition
	{
		[Ordinal(4)] 
		[RED("noWeaponsRestrictionApplied")] 
		public CBool NoWeaponsRestrictionApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PassengerEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
