using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleColorSelectionSliderHoldEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public VehicleColorSelectionSliderHoldEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
