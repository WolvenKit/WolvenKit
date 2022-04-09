using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimSetTextEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("localizationString")] 
		public CString LocalizationString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkanimSetTextEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
