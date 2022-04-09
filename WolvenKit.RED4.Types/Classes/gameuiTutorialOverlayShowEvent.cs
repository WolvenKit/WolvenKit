using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialOverlayShowEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiTutorialOverlayShowEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
