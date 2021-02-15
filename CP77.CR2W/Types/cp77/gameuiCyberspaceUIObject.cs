using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCyberspaceUIObject : gameObject
	{
		[Ordinal(40)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(41)] [RED("mappinType")] public CEnum<gameuiCyberspaceElementType> MappinType { get; set; }
		[Ordinal(42)] [RED("caption")] public CString Caption { get; set; }

		public gameuiCyberspaceUIObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
