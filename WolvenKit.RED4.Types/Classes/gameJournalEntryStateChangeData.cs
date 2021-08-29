using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalEntryStateChangeData : RedBaseClass
	{
		private CHandle<gameJournalPath> _entryPath;
		private CString _entryName;
		private CName _entryType;
		private CBool _isEntryTracked;
		private CBool _isQuestEntryTracked;
		private CEnum<gameJournalEntryState> _oldState;
		private CEnum<gameJournalEntryState> _newState;
		private CEnum<gameJournalNotifyOption> _notifyOption;
		private CEnum<gameJournalChangeType> _changeType;

		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetProperty(ref _entryPath);
			set => SetProperty(ref _entryPath, value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CString EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CName EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		[Ordinal(3)] 
		[RED("isEntryTracked")] 
		public CBool IsEntryTracked
		{
			get => GetProperty(ref _isEntryTracked);
			set => SetProperty(ref _isEntryTracked, value);
		}

		[Ordinal(4)] 
		[RED("isQuestEntryTracked")] 
		public CBool IsQuestEntryTracked
		{
			get => GetProperty(ref _isQuestEntryTracked);
			set => SetProperty(ref _isQuestEntryTracked, value);
		}

		[Ordinal(5)] 
		[RED("oldState")] 
		public CEnum<gameJournalEntryState> OldState
		{
			get => GetProperty(ref _oldState);
			set => SetProperty(ref _oldState, value);
		}

		[Ordinal(6)] 
		[RED("newState")] 
		public CEnum<gameJournalEntryState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		[Ordinal(7)] 
		[RED("notifyOption")] 
		public CEnum<gameJournalNotifyOption> NotifyOption
		{
			get => GetProperty(ref _notifyOption);
			set => SetProperty(ref _notifyOption, value);
		}

		[Ordinal(8)] 
		[RED("changeType")] 
		public CEnum<gameJournalChangeType> ChangeType
		{
			get => GetProperty(ref _changeType);
			set => SetProperty(ref _changeType, value);
		}
	}
}
