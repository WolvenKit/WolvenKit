using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArmorEquipInventoryItemController : inkButtonDpadSupportedController
	{
		[Ordinal(26)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(27)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(28)] 
		[RED("empty")] 
		public CBool Empty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ArmorEquipInventoryItemController()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
