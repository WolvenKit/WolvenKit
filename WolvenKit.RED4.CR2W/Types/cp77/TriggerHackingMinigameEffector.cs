using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerHackingMinigameEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private CUInt32 _listener;
		private gameItemID _item;
		private TweakDBID _reward;
		private CString _journalEntry;
		private CName _fact;
		private CInt32 _factValue;
		private CBool _showPopup;
		private CBool _returnToJournal;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(2)] 
		[RED("item")] 
		public gameItemID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(3)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetProperty(ref _reward);
			set => SetProperty(ref _reward, value);
		}

		[Ordinal(4)] 
		[RED("journalEntry")] 
		public CString JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(5)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetProperty(ref _fact);
			set => SetProperty(ref _fact, value);
		}

		[Ordinal(6)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetProperty(ref _factValue);
			set => SetProperty(ref _factValue, value);
		}

		[Ordinal(7)] 
		[RED("showPopup")] 
		public CBool ShowPopup
		{
			get => GetProperty(ref _showPopup);
			set => SetProperty(ref _showPopup, value);
		}

		[Ordinal(8)] 
		[RED("returnToJournal")] 
		public CBool ReturnToJournal
		{
			get => GetProperty(ref _returnToJournal);
			set => SetProperty(ref _returnToJournal, value);
		}

		public TriggerHackingMinigameEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
