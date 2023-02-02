using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationOptionVersionUpdateInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("curOptionNames")] 
		public CArray<CName> CurOptionNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("curDefintionName")] 
		public CName CurDefintionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("optionPrereqs")] 
		public CArray<gameuiCharacterCustomizationOptionVersionPrereq> OptionPrereqs
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationOptionVersionPrereq>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationOptionVersionPrereq>>(value);
		}

		[Ordinal(3)] 
		[RED("newOptionName")] 
		public CName NewOptionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("newDefinitionName")] 
		public CName NewDefinitionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("replaceCurOption")] 
		public CBool ReplaceCurOption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCharacterCustomizationOptionVersionUpdateInfo()
		{
			CurOptionNames = new();
			OptionPrereqs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
