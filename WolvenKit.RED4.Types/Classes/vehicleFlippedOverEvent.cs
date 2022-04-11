using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleFlippedOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isFlippedOver")] 
		public CBool IsFlippedOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleFlippedOverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
