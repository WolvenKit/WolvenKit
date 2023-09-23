using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingGarmentItemPreviewGameController : gameuiWardrobeSetPreviewGameController
	{
		[Ordinal(24)] 
		[RED("initialItems")] 
		public CArray<gameItemID> InitialItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(25)] 
		[RED("previewedItem")] 
		public gameItemID PreviewedItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public CraftingGarmentItemPreviewGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
