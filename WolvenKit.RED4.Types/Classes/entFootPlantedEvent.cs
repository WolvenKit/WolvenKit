using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entFootPlantedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("customAction")] 
		public CName CustomAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("footSide")] 
		public CEnum<animEventSide> FootSide
		{
			get => GetPropertyValue<CEnum<animEventSide>>();
			set => SetPropertyValue<CEnum<animEventSide>>(value);
		}

		public entFootPlantedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
