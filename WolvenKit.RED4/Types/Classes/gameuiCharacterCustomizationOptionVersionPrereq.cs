using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationOptionVersionPrereq : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("optionName")] 
		public CName OptionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("definitionName")] 
		public CName DefinitionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationOptionVersionPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
