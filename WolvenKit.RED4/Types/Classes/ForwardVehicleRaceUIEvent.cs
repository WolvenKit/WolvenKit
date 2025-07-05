using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForwardVehicleRaceUIEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<vehicleRaceUI> Mode
		{
			get => GetPropertyValue<CEnum<vehicleRaceUI>>();
			set => SetPropertyValue<CEnum<vehicleRaceUI>>(value);
		}

		[Ordinal(1)] 
		[RED("maxPosition")] 
		public CInt32 MaxPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("maxCheckpoints")] 
		public CInt32 MaxCheckpoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ForwardVehicleRaceUIEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
