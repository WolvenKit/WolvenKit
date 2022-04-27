using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleParkedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("park")] 
		public CBool Park
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleParkedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
