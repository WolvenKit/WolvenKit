using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioBlip : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blipEventName")] 
		public CName BlipEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioRadioBlip()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
