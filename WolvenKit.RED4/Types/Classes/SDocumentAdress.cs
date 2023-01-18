using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDocumentAdress : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("folderID")] 
		public CInt32 FolderID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("documentID")] 
		public CInt32 DocumentID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SDocumentAdress()
		{
			FolderID = -1;
			DocumentID = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
