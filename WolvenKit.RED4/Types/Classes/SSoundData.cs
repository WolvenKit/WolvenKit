using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSoundData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetAudioName")] 
		public CName WidgetAudioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("onPressKey")] 
		public CName OnPressKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("onReleaseKey")] 
		public CName OnReleaseKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("onHoverOverKey")] 
		public CName OnHoverOverKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("onHoverOutKey")] 
		public CName OnHoverOutKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SSoundData()
		{
			WidgetAudioName = "Button";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
