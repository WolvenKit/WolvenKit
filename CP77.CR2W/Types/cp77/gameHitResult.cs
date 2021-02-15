using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitResult : CVariable
	{
		[Ordinal(0)] [RED("hitPositionEnter")] public Vector4 HitPositionEnter { get; set; }
		[Ordinal(1)] [RED("hitPositionExit")] public Vector4 HitPositionExit { get; set; }
		[Ordinal(2)] [RED("enterDistanceFromOriginSq")] public CFloat EnterDistanceFromOriginSq { get; set; }

		public gameHitResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
