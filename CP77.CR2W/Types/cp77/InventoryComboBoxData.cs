using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryComboBoxData : CVariable
	{
		[Ordinal(0)] [RED("Message")] public CString Message { get; set; }
		[Ordinal(1)] [RED("ItemsToDisplay")] public CArray<InventoryItemData> ItemsToDisplay { get; set; }
		[Ordinal(2)] [RED("ShowUnequipButton")] public CBool ShowUnequipButton { get; set; }
		[Ordinal(3)] [RED("ShowcaseItem")] public InventoryItemData ShowcaseItem { get; set; }
		[Ordinal(4)] [RED("DisplayShowcase")] public CBool DisplayShowcase { get; set; }
		[Ordinal(5)] [RED("ForceDouble")] public CBool ForceDouble { get; set; }

		public InventoryComboBoxData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
