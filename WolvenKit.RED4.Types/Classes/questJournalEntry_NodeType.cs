using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJournalEntry_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _sendNotification;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}

		public questJournalEntry_NodeType()
		{
			_sendNotification = true;
		}
	}
}
