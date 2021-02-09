using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EvaluateMinigame : redEvent
	{
		[Ordinal(0)]  [RED("minigameBB")] public CHandle<gameIBlackboard> MinigameBB { get; set; }
		[Ordinal(1)]  [RED("reward")] public TweakDBID Reward { get; set; }
		[Ordinal(2)]  [RED("journalEntry")] public CString JournalEntry { get; set; }
		[Ordinal(3)]  [RED("fact")] public CName Fact { get; set; }
		[Ordinal(4)]  [RED("factValue")] public CInt32 FactValue { get; set; }
		[Ordinal(5)]  [RED("item")] public gameItemID Item { get; set; }
		[Ordinal(6)]  [RED("showPopup")] public CBool ShowPopup { get; set; }
		[Ordinal(7)]  [RED("returnToJournal")] public CBool ReturnToJournal { get; set; }

		public EvaluateMinigame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
