using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLanguage_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questLanguageMode> Mode
		{
			get => GetPropertyValue<CEnum<questLanguageMode>>();
			set => SetPropertyValue<CEnum<questLanguageMode>>(value);
		}

		[Ordinal(1)] 
		[RED("languageCode")] 
		public CString LanguageCode
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questLanguage_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
