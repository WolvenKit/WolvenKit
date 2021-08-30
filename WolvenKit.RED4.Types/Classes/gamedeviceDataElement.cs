using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceDataElement : RedBaseClass
	{
		private CString _owner;
		private CString _date;
		private CString _title;
		private CString _content;
		private redResourceReferenceScriptToken _videoPath;
		private CHandle<gameJournalPath> _journalPath;
		private CName _documentName;
		private gamedeviceQuestInfo _questInfo;
		private CBool _isEncrypted;
		private CBool _wasRead;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("owner")] 
		public CString Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("date")] 
		public CString Date
		{
			get => GetProperty(ref _date);
			set => SetProperty(ref _date, value);
		}

		[Ordinal(2)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("content")] 
		public CString Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(4)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(5)] 
		[RED("journalPath")] 
		public CHandle<gameJournalPath> JournalPath
		{
			get => GetProperty(ref _journalPath);
			set => SetProperty(ref _journalPath, value);
		}

		[Ordinal(6)] 
		[RED("documentName")] 
		public CName DocumentName
		{
			get => GetProperty(ref _documentName);
			set => SetProperty(ref _documentName, value);
		}

		[Ordinal(7)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetProperty(ref _questInfo);
			set => SetProperty(ref _questInfo, value);
		}

		[Ordinal(8)] 
		[RED("isEncrypted")] 
		public CBool IsEncrypted
		{
			get => GetProperty(ref _isEncrypted);
			set => SetProperty(ref _isEncrypted, value);
		}

		[Ordinal(9)] 
		[RED("wasRead")] 
		public CBool WasRead
		{
			get => GetProperty(ref _wasRead);
			set => SetProperty(ref _wasRead, value);
		}

		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public gamedeviceDataElement()
		{
			_isEnabled = true;
		}
	}
}
