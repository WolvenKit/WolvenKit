using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentAdress : CVariable
	{
		[Ordinal(0)] [RED("folderID")] public CInt32 FolderID { get; set; }
		[Ordinal(1)] [RED("documentID")] public CInt32 DocumentID { get; set; }

		public SDocumentAdress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
