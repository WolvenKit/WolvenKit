using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_IndustrialArm : animAnimFeature
	{
		[Ordinal(0)]  [RED("idleAnimNumber")] public CInt32 IdleAnimNumber { get; set; }
		[Ordinal(1)]  [RED("isRotate")] public CBool IsRotate { get; set; }
		[Ordinal(2)]  [RED("isDistraction")] public CBool IsDistraction { get; set; }
		[Ordinal(3)]  [RED("isPoke")] public CBool IsPoke { get; set; }

		public AnimFeature_IndustrialArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
