using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingPopupData : inkGameNotificationData
	{
		private CHandle<InventoryTooltipData> _itemTooltipData;
		private CEnum<CraftingCommands> _craftingCommand;

		[Ordinal(6)] 
		[RED("itemTooltipData")] 
		public CHandle<InventoryTooltipData> ItemTooltipData
		{
			get
			{
				if (_itemTooltipData == null)
				{
					_itemTooltipData = (CHandle<InventoryTooltipData>) CR2WTypeManager.Create("handle:InventoryTooltipData", "itemTooltipData", cr2w, this);
				}
				return _itemTooltipData;
			}
			set
			{
				if (_itemTooltipData == value)
				{
					return;
				}
				_itemTooltipData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("craftingCommand")] 
		public CEnum<CraftingCommands> CraftingCommand
		{
			get
			{
				if (_craftingCommand == null)
				{
					_craftingCommand = (CEnum<CraftingCommands>) CR2WTypeManager.Create("CraftingCommands", "craftingCommand", cr2w, this);
				}
				return _craftingCommand;
			}
			set
			{
				if (_craftingCommand == value)
				{
					return;
				}
				_craftingCommand = value;
				PropertySet(this);
			}
		}

		public CraftingPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
