using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingPopupData : inkGameNotificationData
	{
		private CHandle<InventoryTooltipData> _itemTooltipData;
		private CEnum<CraftingCommands> _craftingCommand;

		[Ordinal(6)] 
		[RED("itemTooltipData")] 
		public CHandle<InventoryTooltipData> ItemTooltipData
		{
			get => GetProperty(ref _itemTooltipData);
			set => SetProperty(ref _itemTooltipData, value);
		}

		[Ordinal(7)] 
		[RED("craftingCommand")] 
		public CEnum<CraftingCommands> CraftingCommand
		{
			get => GetProperty(ref _craftingCommand);
			set => SetProperty(ref _craftingCommand, value);
		}
	}
}
