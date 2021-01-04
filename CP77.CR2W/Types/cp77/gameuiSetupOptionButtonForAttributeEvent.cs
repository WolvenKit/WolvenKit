using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupOptionButtonForAttributeEvent : redEvent
	{
		[Ordinal(0)]  [RED("attribute")] public CUInt32 Attribute { get; set; }
		[Ordinal(1)]  [RED("value")] public CString Value { get; set; }

		public gameuiSetupOptionButtonForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
