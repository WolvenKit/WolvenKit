using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SimpleBounce : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("areChannelsResaved")] public CBool AreChannelsResaved { get; set; }
		[Ordinal(13)] [RED("outputDriverTrack")] public animNamedTrackIndex OutputDriverTrack { get; set; }
		[Ordinal(14)] [RED("debug")] public CBool Debug { get; set; }
		[Ordinal(15)] [RED("startTransform")] public animTransformIndex StartTransform { get; set; }
		[Ordinal(16)] [RED("endTransform")] public animTransformIndex EndTransform { get; set; }
		[Ordinal(17)] [RED("multiplier")] public CFloat Multiplier { get; set; }
		[Ordinal(18)] [RED("negativeMultiplier")] public CFloat NegativeMultiplier { get; set; }
		[Ordinal(19)] [RED("smoothStep")] public CFloat SmoothStep { get; set; }
		[Ordinal(20)] [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(21)] [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(22)] [RED("transformOutputs")] public CArray<animSimpleBounceTransformOutput> TransformOutputs { get; set; }
		[Ordinal(23)] [RED("trackOutputs")] public CArray<animSimpleBounceTrackOutput> TrackOutputs { get; set; }

		public animAnimNode_SimpleBounce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
