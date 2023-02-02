using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioCommonEntitySettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("onAttachEvent")] 
		public CName OnAttachEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("stopAllSoundsOnDetach")] 
		public CBool StopAllSoundsOnDetach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioCommonEntitySettings()
		{
			StopAllSoundsOnDetach = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
