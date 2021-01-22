using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnWorldMarker : CVariable
	{
		[Ordinal(0)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<scnWorldMarkerType> Type { get; set; }

		public scnWorldMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
