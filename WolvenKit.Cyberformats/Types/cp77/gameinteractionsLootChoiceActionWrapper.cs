using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLootChoiceActionWrapper : CVariable
	{
		[Ordinal(0)] [RED("removeItem")] public CBool RemoveItem { get; set; }
		[Ordinal(1)] [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(2)] [RED("action")] public CName Action { get; set; }

		public gameinteractionsLootChoiceActionWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
