using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDocumentAdress : RedBaseClass
	{
		private CInt32 _folderID;
		private CInt32 _documentID;

		[Ordinal(0)] 
		[RED("folderID")] 
		public CInt32 FolderID
		{
			get => GetProperty(ref _folderID);
			set => SetProperty(ref _folderID, value);
		}

		[Ordinal(1)] 
		[RED("documentID")] 
		public CInt32 DocumentID
		{
			get => GetProperty(ref _documentID);
			set => SetProperty(ref _documentID, value);
		}
	}
}
