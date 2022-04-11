using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimSetTextEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("localizationString")] 
		public CString LocalizationString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
