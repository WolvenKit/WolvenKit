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
			ExitSlot = "default";
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
