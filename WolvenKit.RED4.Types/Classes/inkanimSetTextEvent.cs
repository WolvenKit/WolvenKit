using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimSetTextEvent : inkanimEvent
	{
		private CString _localizationString;

		[Ordinal(1)] 
		[RED("localizationString")] 
		public CString LocalizationString
		{
			get => GetProperty(ref _localizationString);
			set => SetProperty(ref _localizationString, value);
		}
	}
}
