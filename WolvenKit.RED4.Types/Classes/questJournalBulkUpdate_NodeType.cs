using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJournalBulkUpdate_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CName _requiredEntryType;
		private CName _requiredEntryState;
		private CName _newEntryState;
		private CBool _sendNotification;
		private CBool _propagateChange;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("requiredEntryType")] 
		public CName RequiredEntryType
		{
			get => GetProperty(ref _requiredEntryType);
			set => SetProperty(ref _requiredEntryType, value);
		}

		[Ordinal(2)] 
		[RED("requiredEntryState")] 
		public CName RequiredEntryState
		{
			get => GetProperty(ref _requiredEntryState);
			set => SetProperty(ref _requiredEntryState, value);
		}

		[Ordinal(3)] 
		[RED("newEntryState")] 
		public CName NewEntryState
		{
			get => GetProperty(ref _newEntryState);
			set => SetProperty(ref _newEntryState, value);
		}

		[Ordinal(4)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}

		[Ordinal(5)] 
		[RED("propagateChange")] 
		public CBool PropagateChange
		{
			get => GetProperty(ref _propagateChange);
			set => SetProperty(ref _propagateChange, value);
		}
	}
}
