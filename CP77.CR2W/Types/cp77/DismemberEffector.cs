using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DismemberEffector : gameEffector
	{
		[Ordinal(0)] [RED("bodyPart")] public CName BodyPart { get; set; }
		[Ordinal(1)] [RED("woundType")] public CName WoundType { get; set; }
		[Ordinal(2)] [RED("hitPosition")] public Vector3 HitPosition { get; set; }
		[Ordinal(3)] [RED("isCritical")] public CBool IsCritical { get; set; }

		public DismemberEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
