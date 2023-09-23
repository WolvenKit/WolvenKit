using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiForcePlayerCustomizationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("customizationPart")] 
		public CEnum<gameuiCharacterCustomizationPart> CustomizationPart
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationPart>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationPart>>(value);
		}

		[Ordinal(1)] 
		[RED("uiSlot")] 
		public CName UiSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("partUiSlot")] 
		public CName PartUiSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("partIndex")] 
		public CUInt32 PartIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("definitionUiSlot")] 
		public CName DefinitionUiSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiForcePlayerCustomizationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
