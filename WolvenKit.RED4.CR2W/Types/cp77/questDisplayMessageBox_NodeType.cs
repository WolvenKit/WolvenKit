using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDisplayMessageBox_NodeType : questIUIManagerNodeType
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

		public questDisplayMessageBox_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
