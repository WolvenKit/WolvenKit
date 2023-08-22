using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingGarmentItemPreviewGameController : gameuiWardrobeSetPreviewGameController
	{
		[Ordinal(23)] 
		[RED("initialItems")] 
		public CArray<gameItemID> InitialItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(24)] 
		[RED("previewedItem")] 
		public gameItemID PreviewedItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public CraftingGarmentItemPreviewGameController()
		{
			InitialItems = new();
			PreviewedItem = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
