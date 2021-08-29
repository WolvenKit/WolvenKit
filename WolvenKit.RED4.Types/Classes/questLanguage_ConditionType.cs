using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLanguage_ConditionType : questISystemConditionType
	{
		private CEnum<questLanguageMode> _mode;
		private CString _languageCode;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questLanguageMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(1)] 
		[RED("languageCode")] 
		public CString LanguageCode
		{
			get => GetProperty(ref _languageCode);
			set => SetProperty(ref _languageCode, value);
		}

		[Ordinal(2)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}
	}
}
