using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioStationChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("radioIndex")] 
		public CInt32 RadioIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RadioStationChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
