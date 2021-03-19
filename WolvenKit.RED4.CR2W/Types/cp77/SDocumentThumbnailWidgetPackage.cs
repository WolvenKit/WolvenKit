using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentThumbnailWidgetPackage : SWidgetPackage
	{
		private CString _folderName;
		private SDocumentAdress _documentAdress;
		private CEnum<EDocumentType> _documentType;
		private gamedeviceQuestInfo _questInfo;
		private CBool _wasRead;
		private CBool _isOpened;

		[Ordinal(17)] 
		[RED("folderName")] 
		public CString FolderName
		{
			get => GetProperty(ref _folderName);
			set => SetProperty(ref _folderName, value);
		}

		[Ordinal(18)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetProperty(ref _documentAdress);
			set => SetProperty(ref _documentAdress, value);
		}

		[Ordinal(19)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		[Ordinal(20)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetProperty(ref _questInfo);
			set => SetProperty(ref _questInfo, value);
		}

		[Ordinal(21)] 
		[RED("wasRead")] 
		public CBool WasRead
		{
			get => GetProperty(ref _wasRead);
			set => SetProperty(ref _wasRead, value);
		}

		[Ordinal(22)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get => GetProperty(ref _isOpened);
			set => SetProperty(ref _isOpened, value);
		}

		public SDocumentThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
