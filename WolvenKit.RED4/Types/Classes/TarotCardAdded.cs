using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TarotCardAdded : redEvent
	{
		[Ordinal(0)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public TarotCardAdded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
