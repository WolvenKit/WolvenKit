using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DriveEvents : VehicleEventsTransition
	{
		[Ordinal(4)] 
		[RED("inCombatBlockingForbiddenZone")] 
		public CBool InCombatBlockingForbiddenZone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DriveEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
