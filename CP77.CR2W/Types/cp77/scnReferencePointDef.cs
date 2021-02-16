using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnReferencePointDef : CVariable
	{
		[Ordinal(0)] [RED("id")] public scnReferencePointId Id { get; set; }
		[Ordinal(1)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(2)] [RED("originMarker")] public scnMarker OriginMarker { get; set; }

		public scnReferencePointDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
