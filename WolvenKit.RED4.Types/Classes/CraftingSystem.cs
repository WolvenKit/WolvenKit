using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("lastActionStatus")] 
		public CBool LastActionStatus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetPropertyValue<CHandle<CraftBook>>();
			set => SetPropertyValue<CHandle<CraftBook>>(value);
		}

		[Ordinal(2)] 
		[RED("callback")] 
		public CHandle<CraftingSystemInventoryCallback> Callback
		{
			get => GetPropertyValue<CHandle<CraftingSystemInventoryCallback>>();
			set => SetPropertyValue<CHandle<CraftingSystemInventoryCallback>>(value);
		}

		[Ordinal(3)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(4)] 
		[RED("itemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get => GetPropertyValue<CEnum<gameItemIconGender>>();
			set => SetPropertyValue<CEnum<gameItemIconGender>>(value);
		}

		public CraftingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
