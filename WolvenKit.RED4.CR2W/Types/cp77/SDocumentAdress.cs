using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentAdress : CVariable
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

		public SDocumentAdress(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
