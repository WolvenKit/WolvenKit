using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Locomotion : animAnimFeature
	{
		[Ordinal(0)] [RED("action")] public CInt32 Action { get; set; }
		[Ordinal(1)] [RED("style")] public CInt32 Style { get; set; }
		[Ordinal(2)] [RED("pathCurvature")] public CFloat PathCurvature { get; set; }
		[Ordinal(3)] [RED("inclineAngle")] public CFloat InclineAngle { get; set; }
		[Ordinal(4)] [RED("groundAngle")] public CFloat GroundAngle { get; set; }
		[Ordinal(5)] [RED("animDeltaZ")] public CFloat AnimDeltaZ { get; set; }
		[Ordinal(6)] [RED("animationPlaybackTime")] public CFloat AnimationPlaybackTime { get; set; }
		[Ordinal(7)] [RED("footScaleFactor")] public CFloat FootScaleFactor { get; set; }
		[Ordinal(8)] [RED("directionalStartAngle")] public CFloat DirectionalStartAngle { get; set; }
		[Ordinal(9)] [RED("speedProgress")] public CFloat SpeedProgress { get; set; }
		[Ordinal(10)] [RED("isOnStairs")] public CBool IsOnStairs { get; set; }
		[Ordinal(11)] [RED("areAnimWrappersUnlocked")] public CBool AreAnimWrappersUnlocked { get; set; }

		public animAnimFeature_Locomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
