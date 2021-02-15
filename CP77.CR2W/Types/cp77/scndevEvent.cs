using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scndevEvent : CVariable
	{
		[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<scndevEventType> Type { get; set; }
		[Ordinal(2)] [RED("message")] public CString Message { get; set; }

		public scndevEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
