using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("counter")] public inkTextWidgetReference Counter { get; set; }
		[Ordinal(2)]  [RED("collapseIcon")] public inkWidgetReference CollapseIcon { get; set; }
		[Ordinal(3)]  [RED("isNewFlag")] public inkWidgetReference IsNewFlag { get; set; }
		[Ordinal(4)]  [RED("entryData")] public CHandle<ShardEntryData> EntryData { get; set; }
		[Ordinal(5)]  [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(6)]  [RED("activeItemSync")] public wCHandle<CodexListSyncData> ActiveItemSync { get; set; }
		[Ordinal(7)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(8)]  [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(9)]  [RED("isItemToggled")] public CBool IsItemToggled { get; set; }

		public ShardItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
