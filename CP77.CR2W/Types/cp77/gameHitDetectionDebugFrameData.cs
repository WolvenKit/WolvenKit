using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameData : CVariable
	{
		[Ordinal(0)] [RED("t")] public CBool T { get; set; }
		[Ordinal(1)] [RED("mponent")] public wCHandle<gameHitRepresentationComponent> Mponent { get; set; }
		[Ordinal(2)] [RED("tTime")] public netTime TTime { get; set; }
		[Ordinal(3)] [RED("apes")] public CArray<gameHitDetectionDebugFrameDataShapeEntry> Apes { get; set; }

		public gameHitDetectionDebugFrameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
