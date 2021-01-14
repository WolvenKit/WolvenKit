using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisLootData : CVariable
	{
		[Ordinal(0)]  [RED("choices")] public CArray<gameinteractionsvisInteractionChoiceData> Choices { get; set; }
		[Ordinal(1)]  [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }
		[Ordinal(2)]  [RED("e3hack_isWeapon")] public CBool E3hack_isWeapon { get; set; }
		[Ordinal(3)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(4)]  [RED("isListOpen")] public CBool IsListOpen { get; set; }
		[Ordinal(5)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(6)]  [RED("itemIDs")] public CArray<gameItemID> ItemIDs { get; set; }
		[Ordinal(7)]  [RED("ownerId")] public entEntityID OwnerId { get; set; }
		[Ordinal(8)]  [RED("title")] public CString Title { get; set; }

		public gameinteractionsvisLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
