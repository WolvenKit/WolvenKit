using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTutorialOverlayHideEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
