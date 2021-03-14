using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerHackingMinigameEffector : gameEffector
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("listener")] public CUInt32 Listener { get; set; }
		[Ordinal(2)] [RED("item")] public gameItemID Item { get; set; }
		[Ordinal(3)] [RED("reward")] public TweakDBID Reward { get; set; }
		[Ordinal(4)] [RED("journalEntry")] public CString JournalEntry { get; set; }
		[Ordinal(5)] [RED("fact")] public CName Fact { get; set; }
		[Ordinal(6)] [RED("factValue")] public CInt32 FactValue { get; set; }
		[Ordinal(7)] [RED("showPopup")] public CBool ShowPopup { get; set; }
		[Ordinal(8)] [RED("returnToJournal")] public CBool ReturnToJournal { get; set; }

		public TriggerHackingMinigameEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
