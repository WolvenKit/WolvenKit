using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualGroup : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(1)]  [RED("arrow")] public inkWidgetReference Arrow { get; set; }
		[Ordinal(2)]  [RED("newWrapper")] public inkWidgetReference NewWrapper { get; set; }
		[Ordinal(3)]  [RED("entryData")] public CHandle<CodexEntryData> EntryData { get; set; }
		[Ordinal(4)]  [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(5)]  [RED("activeItemSync")] public wCHandle<CodexListSyncData> ActiveItemSync { get; set; }
		[Ordinal(6)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(7)]  [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(8)]  [RED("isItemToggled")] public CBool IsItemToggled { get; set; }

		public CodexListVirtualGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
