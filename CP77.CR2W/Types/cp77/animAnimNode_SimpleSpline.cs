using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SimpleSpline : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("areSourceChannelsResaved")] public CBool AreSourceChannelsResaved { get; set; }
		[Ordinal(13)] [RED("startTransform")] public animTransformIndex StartTransform { get; set; }
		[Ordinal(14)] [RED("middleTransform")] public animTransformIndex MiddleTransform { get; set; }
		[Ordinal(15)] [RED("endTransform")] public animTransformIndex EndTransform { get; set; }
		[Ordinal(16)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(17)] [RED("progressMode")] public CEnum<animConstraintWeightMode> ProgressMode { get; set; }
		[Ordinal(18)] [RED("defaultProgress")] public CFloat DefaultProgress { get; set; }
		[Ordinal(19)] [RED("progressTrack")] public animNamedTrackIndex ProgressTrack { get; set; }

		public animAnimNode_SimpleSpline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
