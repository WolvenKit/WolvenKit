using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtRequest_ : CVariable
	{
		[Ordinal(0)] [RED("transitionSpeed")] public CFloat TransitionSpeed { get; set; }
		[Ordinal(1)] [RED("hasOutTransition")] public CBool HasOutTransition { get; set; }
		[Ordinal(2)] [RED("outTransitionSpeed")] public CFloat OutTransitionSpeed { get; set; }
		[Ordinal(3)] [RED("followingSpeedFactorOverride")] public CFloat FollowingSpeedFactorOverride { get; set; }
		[Ordinal(4)] [RED("limits")] public animLookAtLimits Limits { get; set; }
		[Ordinal(5)] [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(6)] [RED("mode")] public CInt32 Mode { get; set; }
		[Ordinal(7)] [RED("calculatePositionInParentSpace")] public CBool CalculatePositionInParentSpace { get; set; }
		[Ordinal(8)] [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(9)] [RED("additionalParts", 2)] public CStatic<animLookAtPartRequest> AdditionalParts { get; set; }
		[Ordinal(10)] [RED("invalid")] public CBool Invalid { get; set; }

		public animLookAtRequest_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
