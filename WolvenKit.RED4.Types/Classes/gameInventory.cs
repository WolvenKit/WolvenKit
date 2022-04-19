using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameInventory : gameComponent
	{
		[Ordinal(4)] 
		[RED("saveInventory")] 
		public CBool SaveInventory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("inventoryTag")] 
		public CEnum<gameSharedInventoryTag> InventoryTag
		{
			get => GetPropertyValue<CEnum<gameSharedInventoryTag>>();
			set => SetPropertyValue<CEnum<gameSharedInventoryTag>>(value);
		}

		[Ordinal(6)] 
		[RED("noInitialization")] 
		public CBool NoInitialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameInventory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
