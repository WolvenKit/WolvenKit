using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsEntry : CVariable
	{
		[Ordinal(0)]  [RED("endDir")] public Vector4 EndDir { get; set; }
		[Ordinal(1)]  [RED("endDisplayName")] public CName EndDisplayName { get; set; }
		[Ordinal(2)]  [RED("endName")] public CName EndName { get; set; }
		[Ordinal(3)]  [RED("endPos")] public Vector4 EndPos { get; set; }
		[Ordinal(4)]  [RED("eventId")] public scnSceneEventId EventId { get; set; }
		[Ordinal(5)]  [RED("flags")] public CUInt8 Flags { get; set; }
		[Ordinal(6)]  [RED("startDir")] public Vector4 StartDir { get; set; }
		[Ordinal(7)]  [RED("startDisplayName")] public CName StartDisplayName { get; set; }
		[Ordinal(8)]  [RED("startName")] public CName StartName { get; set; }
		[Ordinal(9)]  [RED("startPos")] public Vector4 StartPos { get; set; }

		public scnSceneMarkerInternalsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
