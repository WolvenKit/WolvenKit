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
			get => GetProperty(ref _itemModeInstance);
			set => SetProperty(ref _itemModeInstance, value);
		}

		public ItemModeInventoryListenerCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
