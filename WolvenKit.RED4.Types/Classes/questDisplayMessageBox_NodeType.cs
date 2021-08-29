using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDisplayMessageBox_NodeType : questIUIManagerNodeType
	{
		private CString _title;
		private CString _message;
		private LocalizationString _localizedTitle;
		private LocalizationString _localizedMessage;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(2)] 
		[RED("localizedTitle")] 
		public LocalizationString LocalizedTitle
		{
			get => GetProperty(ref _localizedTitle);
			set => SetProperty(ref _localizedTitle, value);
		}

		[Ordinal(3)] 
		[RED("localizedMessage")] 
		public LocalizationString LocalizedMessage
		{
			get => GetProperty(ref _localizedMessage);
			set => SetProperty(ref _localizedMessage, value);
		}
	}
}
