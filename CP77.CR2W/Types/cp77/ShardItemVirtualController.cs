using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(16)] [RED("counter")] public inkTextWidgetReference Counter { get; set; }
		[Ordinal(17)] [RED("collapseIcon")] public inkWidgetReference CollapseIcon { get; set; }
		[Ordinal(18)] [RED("isNewFlag")] public inkWidgetReference IsNewFlag { get; set; }
		[Ordinal(19)] [RED("entryData")] public CHandle<ShardEntryData> EntryData { get; set; }
		[Ordinal(20)] [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(21)] [RED("activeItemSync")] public wCHandle<CodexListSyncData> ActiveItemSync { get; set; }
		[Ordinal(22)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(23)] [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(24)] [RED("isItemToggled")] public CBool IsItemToggled { get; set; }

		public ShardItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
