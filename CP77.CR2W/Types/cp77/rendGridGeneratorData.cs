using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendGridGeneratorData : CVariable
	{
		[Ordinal(0)] [RED("startingPosition")] public Vector3 StartingPosition { get; set; }
		[Ordinal(1)] [RED("rotation")] public EulerAngles Rotation { get; set; }
		[Ordinal(2)] [RED("xStep")] public CFloat XStep { get; set; }
		[Ordinal(3)] [RED("yStep")] public CFloat YStep { get; set; }
		[Ordinal(4)] [RED("numberOfXSteps")] public CUInt32 NumberOfXSteps { get; set; }
		[Ordinal(5)] [RED("numberOfYSteps")] public CUInt32 NumberOfYSteps { get; set; }
		[Ordinal(6)] [RED("orbitDistance")] public CFloat OrbitDistance { get; set; }
		[Ordinal(7)] [RED("zoom")] public CFloat Zoom { get; set; }

		public rendGridGeneratorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
