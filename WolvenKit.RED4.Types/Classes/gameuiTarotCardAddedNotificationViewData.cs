using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTarotCardAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
