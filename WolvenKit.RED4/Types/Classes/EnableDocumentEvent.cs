using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EnableDocumentEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		[Ordinal(1)] 
		[RED("documentName")] 
		public CName DocumentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetPropertyValue<SDocumentAdress>();
			set => SetPropertyValue<SDocumentAdress>(value);
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("entireFolder")] 
		public CBool EntireFolder
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EnableDocumentEvent()
		{
			DocumentAdress = new SDocumentAdress { FolderID = -1, DocumentID = -1 };
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
