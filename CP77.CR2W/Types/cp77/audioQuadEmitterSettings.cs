using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioQuadEmitterSettings : CVariable
	{
		[Ordinal(0)]  [RED("Enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("Interleaved")] public CBool Interleaved { get; set; }
		[Ordinal(2)]  [RED("Radius")] public CFloat Radius { get; set; }
		[Ordinal(3)]  [RED("Offset")] public Vector3 Offset { get; set; }
		[Ordinal(4)]  [RED("Angle")] public CFloat Angle { get; set; }
		[Ordinal(5)]  [RED("Events", 4)] public CArrayFixedSize<audioAudEventStruct> Events { get; set; }

		public audioQuadEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
