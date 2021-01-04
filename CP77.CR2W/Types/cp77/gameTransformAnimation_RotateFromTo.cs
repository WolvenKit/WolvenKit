using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_RotateFromTo : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)]  [RED("movement")] public CHandle<gameTransformAnimation_Movement> Movement { get; set; }
		[Ordinal(1)]  [RED("startRotationEvaluator")] public CHandle<gameTransformAnimation_Rotation> StartRotationEvaluator { get; set; }
		[Ordinal(2)]  [RED("targetRotationEvaluator")] public CHandle<gameTransformAnimation_Rotation> TargetRotationEvaluator { get; set; }

		public gameTransformAnimation_RotateFromTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
