using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeInventoryListenerCallback : gameInventoryScriptCallback
	{
		private wCHandle<InventoryItemModeLogicController> _itemModeInstance;

		[Ordinal(1)] 
		[RED("itemModeInstance")] 
		public wCHandle<InventoryItemModeLogicController> ItemModeInstance
		{
			get
			{
				if (_itemModeInstance == null)
				{
					_itemModeInstance = (wCHandle<InventoryItemModeLogicController>) CR2WTypeManager.Create("whandle:InventoryItemModeLogicController", "itemModeInstance", cr2w, this);
				}
				return _itemModeInstance;
			}
			set
			{
				if (_itemModeInstance == value)
				{
					return;
				}
				_itemModeInstance = value;
				PropertySet(this);
			}
		}

		public ItemModeInventoryListenerCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
