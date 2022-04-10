using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_EntityAppearanceOperationBase : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] 
		[RED("appearanceEntries")] 
		public CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> AppearanceEntries
		{
			get => GetPropertyValue<CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry>>();
			set => SetPropertyValue<CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry>>(value);
		}

		public questCharacterManagerVisuals_EntityAppearanceOperationBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
