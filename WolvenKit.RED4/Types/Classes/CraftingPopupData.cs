using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("itemTooltipData")] 
		public CHandle<InventoryTooltipData> ItemTooltipData
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(8)] 
		[RED("craftingCommand")] 
		public CEnum<CraftingCommands> CraftingCommand
		{
			get => GetPropertyValue<CEnum<CraftingCommands>>();
			set => SetPropertyValue<CEnum<CraftingCommands>>(value);
		}

		public CraftingPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
