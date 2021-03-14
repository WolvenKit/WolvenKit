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
			get
			{
				if (_folderID == null)
				{
					_folderID = (CInt32) CR2WTypeManager.Create("Int32", "folderID", cr2w, this);
				}
				return _folderID;
			}
			set
			{
				if (_folderID == value)
				{
					return;
				}
				_folderID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("documentID")] 
		public CInt32 DocumentID
		{
			get
			{
				if (_documentID == null)
				{
					_documentID = (CInt32) CR2WTypeManager.Create("Int32", "documentID", cr2w, this);
				}
				return _documentID;
			}
			set
			{
				if (_documentID == value)
				{
					return;
				}
				_documentID = value;
				PropertySet(this);
			}
		}

		public SDocumentAdress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
