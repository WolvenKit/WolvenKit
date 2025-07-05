using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleUnableToStartPanicDriving : redEvent
	{
		[Ordinal(0)] 
		[RED("forceExitVehicle")] 
		public CBool ForceExitVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleUnableToStartPanicDriving()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
