using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleToggleBrokenTireEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("tireIndex")] 
		public CUInt32 TireIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleToggleBrokenTireEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
