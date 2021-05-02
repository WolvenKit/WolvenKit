using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentWidgetPackage : SWidgetPackage
	{
		private CString _owner;
		private CString _date;
		private CString _title;
		private CString _content;
		private TweakDBID _image;
		private redResourceReferenceScriptToken _videoPath;
		private CBool _isEncrypted;
		private gamedeviceQuestInfo _questInfo;
		private CBool _wasRead;
		private CEnum<EDocumentType> _documentType;

		[Ordinal(17)] 
		[RED("owner")] 
		public CString Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(18)] 
		[RED("date")] 
		public CString Date
		{
			get => GetProperty(ref _date);
			set => SetProperty(ref _date, value);
		}

		[Ordinal(19)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(20)] 
		[RED("content")] 
		public CString Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(21)] 
		[RED("image")] 
		public TweakDBID Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(22)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(23)] 
		[RED("isEncrypted")] 
		public CBool IsEncrypted
		{
			get => GetProperty(ref _isEncrypted);
			set => SetProperty(ref _isEncrypted, value);
		}

		[Ordinal(24)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetProperty(ref _questInfo);
			set => SetProperty(ref _questInfo, value);
		}

		[Ordinal(25)] 
		[RED("wasRead")] 
		public CBool WasRead
		{
			get => GetProperty(ref _wasRead);
			set => SetProperty(ref _wasRead, value);
		}

		[Ordinal(26)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		public SDocumentWidgetPackage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
