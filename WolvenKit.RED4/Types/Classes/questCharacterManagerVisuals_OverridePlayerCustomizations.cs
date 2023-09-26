using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_OverridePlayerCustomizations : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] 
		[RED("customizationData")] 
		public CArray<gameuiForcePlayerCustomizationData> CustomizationData
		{
			get => GetPropertyValue<CArray<gameuiForcePlayerCustomizationData>>();
			set => SetPropertyValue<CArray<gameuiForcePlayerCustomizationData>>(value);
		}

		public questCharacterManagerVisuals_OverridePlayerCustomizations()
		{
			CustomizationData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
