using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDocumentThumbnailWidgetPackage : SWidgetPackage
	{
		[Ordinal(18)] 
		[RED("folderName")] 
		public CString FolderName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetPropertyValue<SDocumentAdress>();
			set => SetPropertyValue<SDocumentAdress>(value);
		}

		[Ordinal(20)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		[Ordinal(21)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetPropertyValue<gamedeviceQuestInfo>();
			set => SetPropertyValue<gamedeviceQuestInfo>(value);
		}

		[Ordinal(22)] 
		[RED("wasRead")] 
		public CBool WasRead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SDocumentThumbnailWidgetPackage()
		{
			DocumentAdress = new() { FolderID = -1, DocumentID = -1 };
			QuestInfo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
