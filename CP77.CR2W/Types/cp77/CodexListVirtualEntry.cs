using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualEntry : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("activeItemSync")] public wCHandle<CodexListSyncData> ActiveItemSync { get; set; }
		[Ordinal(1)]  [RED("entryData")] public CHandle<CodexEntryData> EntryData { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(4)]  [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(5)]  [RED("isItemToggled")] public CBool IsItemToggled { get; set; }
		[Ordinal(6)]  [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(7)]  [RED("newWrapper")] public inkWidgetReference NewWrapper { get; set; }
		[Ordinal(8)]  [RED("title")] public inkTextWidgetReference Title { get; set; }

		public CodexListVirtualEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
