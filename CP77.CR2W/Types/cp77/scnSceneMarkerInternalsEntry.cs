using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsEntry : CVariable
	{
		[Ordinal(0)] [RED("eventId")] public scnSceneEventId EventId { get; set; }
		[Ordinal(1)] [RED("startName")] public CName StartName { get; set; }
		[Ordinal(2)] [RED("endName")] public CName EndName { get; set; }
		[Ordinal(3)] [RED("startDisplayName")] public CName StartDisplayName { get; set; }
		[Ordinal(4)] [RED("endDisplayName")] public CName EndDisplayName { get; set; }
		[Ordinal(5)] [RED("startPos")] public Vector4 StartPos { get; set; }
		[Ordinal(6)] [RED("endPos")] public Vector4 EndPos { get; set; }
		[Ordinal(7)] [RED("startDir")] public Vector4 StartDir { get; set; }
		[Ordinal(8)] [RED("endDir")] public Vector4 EndDir { get; set; }
		[Ordinal(9)] [RED("flags")] public CUInt8 Flags { get; set; }

		public scnSceneMarkerInternalsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
