using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLootChoiceActionWrapper : CVariable
	{
		[Ordinal(0)]  [RED("action")] public CName Action { get; set; }
		[Ordinal(1)]  [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(2)]  [RED("removeItem")] public CBool RemoveItem { get; set; }

		public gameinteractionsLootChoiceActionWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
