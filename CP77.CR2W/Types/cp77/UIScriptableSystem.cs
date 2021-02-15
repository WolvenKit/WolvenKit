using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("backpackActiveSorting")] public CInt32 BackpackActiveSorting { get; set; }
		[Ordinal(1)] [RED("backpackActiveFilter")] public CInt32 BackpackActiveFilter { get; set; }
		[Ordinal(2)] [RED("isBackpackActiveFilterSaved")] public CBool IsBackpackActiveFilterSaved { get; set; }
		[Ordinal(3)] [RED("vendorPanelPlayerActiveSorting")] public CInt32 VendorPanelPlayerActiveSorting { get; set; }
		[Ordinal(4)] [RED("vendorPanelVendorActiveSorting")] public CInt32 VendorPanelVendorActiveSorting { get; set; }
		[Ordinal(5)] [RED("newItems")] public CArray<gameItemID> NewItems { get; set; }
		[Ordinal(6)] [RED("attachedPlayer")] public wCHandle<PlayerPuppet> AttachedPlayer { get; set; }
		[Ordinal(7)] [RED("inventoryListenerCallback")] public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback { get; set; }
		[Ordinal(8)] [RED("inventoryListener")] public CHandle<gameInventoryScriptListener> InventoryListener { get; set; }

		public UIScriptableSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
