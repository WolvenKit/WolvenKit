using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleRadioEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("setStation")] 
		public CBool SetStation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("station")] 
		public CInt32 Station
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public VehicleRadioEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
