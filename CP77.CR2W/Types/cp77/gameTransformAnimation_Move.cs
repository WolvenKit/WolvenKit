using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Move : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] [RED("startPositionEvaluator")] public CHandle<gameTransformAnimation_Position> StartPositionEvaluator { get; set; }
		[Ordinal(1)] [RED("targetPositionEvaluator")] public CHandle<gameTransformAnimation_Position> TargetPositionEvaluator { get; set; }
		[Ordinal(2)] [RED("movement")] public CHandle<gameTransformAnimation_Movement> Movement { get; set; }

		public gameTransformAnimation_Move(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
