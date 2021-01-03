using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TriggerHackingMinigameEffector : gameEffector
	{
		[Ordinal(0)]  [RED("fact")] public CName Fact { get; set; }
		[Ordinal(1)]  [RED("factValue")] public CInt32 FactValue { get; set; }
		[Ordinal(2)]  [RED("item")] public gameItemID Item { get; set; }
		[Ordinal(3)]  [RED("journalEntry")] public CString JournalEntry { get; set; }
		[Ordinal(4)]  [RED("listener")] public CUInt32 Listener { get; set; }
		[Ordinal(5)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(6)]  [RED("returnToJournal")] public CBool ReturnToJournal { get; set; }
		[Ordinal(7)]  [RED("reward")] public TweakDBID Reward { get; set; }
		[Ordinal(8)]  [RED("showPopup")] public CBool ShowPopup { get; set; }

		public TriggerHackingMinigameEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
