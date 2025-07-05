using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDialogDisplayString : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("translation")] 
		public CString Translation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("preTranslatedText")] 
		public CString PreTranslatedText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("postTranslatedText")] 
		public CString PostTranslatedText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("language")] 
		public CEnum<scnDialogLineLanguage> Language
		{
			get => GetPropertyValue<CEnum<scnDialogLineLanguage>>();
			set => SetPropertyValue<CEnum<scnDialogLineLanguage>>(value);
		}

		public scnDialogDisplayString()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
