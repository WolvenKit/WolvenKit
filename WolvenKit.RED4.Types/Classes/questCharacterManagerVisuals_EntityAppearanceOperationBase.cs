using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerVisuals_EntityAppearanceOperationBase : questICharacterManagerVisuals_NodeSubType
	{
		private CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> _appearanceEntries;

		[Ordinal(0)] 
		[RED("appearanceEntries")] 
		public CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> AppearanceEntries
		{
			get => GetProperty(ref _appearanceEntries);
			set => SetProperty(ref _appearanceEntries, value);
		}
	}
}
