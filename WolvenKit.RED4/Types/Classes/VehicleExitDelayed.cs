using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleExitDelayed : redEvent
	{
		[Ordinal(0)] 
		[RED("isEmergencyExit")] 
		public CBool IsEmergencyExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleExitDelayed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
