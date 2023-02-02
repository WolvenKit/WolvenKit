using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textLocKey")] 
		public CName TextLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("textLocKey_PS4")] 
		public CName TextLocKey_PS4
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("textLocKey_Prospero")] 
		public CName TextLocKey_Prospero
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("textLocKey_XB1")] 
		public CName TextLocKey_XB1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("textLocKey_Scarlett")] 
		public CName TextLocKey_Scarlett
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkPlatformSpecificTextController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
