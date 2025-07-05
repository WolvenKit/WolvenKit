using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleWaterEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isInWater")] 
		public CBool IsInWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleWaterEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
