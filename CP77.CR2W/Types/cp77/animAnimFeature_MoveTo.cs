using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MoveTo : animAnimFeature
	{
		[Ordinal(0)] [RED("initialFwdVector")] public Vector4 InitialFwdVector { get; set; }
		[Ordinal(1)] [RED("targetPositionWs")] public Vector4 TargetPositionWs { get; set; }
		[Ordinal(2)] [RED("targetDirectionWs")] public Vector4 TargetDirectionWs { get; set; }
		[Ordinal(3)] [RED("timeToMove")] public CFloat TimeToMove { get; set; }

		public animAnimFeature_MoveTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
