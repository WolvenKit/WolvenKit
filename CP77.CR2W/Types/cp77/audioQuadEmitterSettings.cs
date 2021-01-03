using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioQuadEmitterSettings : CVariable
	{
		[Ordinal(0)]  [RED("Angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("Enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("Events")] public [4]audioAudEventStruct Events { get; set; }
		[Ordinal(3)]  [RED("Interleaved")] public CBool Interleaved { get; set; }
		[Ordinal(4)]  [RED("Offset")] public Vector3 Offset { get; set; }
		[Ordinal(5)]  [RED("Radius")] public CFloat Radius { get; set; }

		public audioQuadEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
