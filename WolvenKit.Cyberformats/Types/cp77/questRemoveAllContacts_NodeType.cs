using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRemoveAllContacts_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] [RED("excludedContacts")] public CArray<CHandle<gameJournalPath>> ExcludedContacts { get; set; }

		public questRemoveAllContacts_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
