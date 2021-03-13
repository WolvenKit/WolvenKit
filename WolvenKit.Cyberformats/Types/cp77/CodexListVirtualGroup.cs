using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualGroup : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(16)] [RED("arrow")] public inkWidgetReference Arrow { get; set; }
		[Ordinal(17)] [RED("newWrapper")] public inkWidgetReference NewWrapper { get; set; }
		[Ordinal(18)] [RED("entryData")] public CHandle<CodexEntryData> EntryData { get; set; }
		[Ordinal(19)] [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(20)] [RED("activeItemSync")] public wCHandle<CodexListSyncData> ActiveItemSync { get; set; }
		[Ordinal(21)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(22)] [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(23)] [RED("isItemToggled")] public CBool IsItemToggled { get; set; }

		public CodexListVirtualGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
