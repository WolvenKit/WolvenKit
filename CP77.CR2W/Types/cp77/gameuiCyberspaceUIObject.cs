using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCyberspaceUIObject : gameObject
	{
		[Ordinal(0)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)]  [RED("caption")] public CString Caption { get; set; }
		[Ordinal(2)]  [RED("mappinType")] public CEnum<gameuiCyberspaceElementType> MappinType { get; set; }

		public gameuiCyberspaceUIObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
