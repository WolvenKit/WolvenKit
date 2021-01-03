using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questRemoveAllContacts_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)]  [RED("excludedContacts")] public CArray<CHandle<gameJournalPath>> ExcludedContacts { get; set; }

		public questRemoveAllContacts_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
