using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemModeInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(0)]  [RED("itemModeInstance")] public wCHandle<InventoryItemModeLogicController> ItemModeInstance { get; set; }

		public ItemModeInventoryListenerCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
