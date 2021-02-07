using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimation : ISerializable
	{
		[Ordinal(0)]  [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)]  [RED("animationType")] public CEnum<animAnimationType> AnimationType { get; set; }
		[Ordinal(4)]  [RED("animBuffer")] public CHandle<animIAnimationBuffer> AnimBuffer { get; set; }
		[Ordinal(5)]  [RED("additionalTransforms")] public animAdditionalTransformContainer AdditionalTransforms { get; set; }
		[Ordinal(6)]  [RED("additionalTracks")] public animAdditionalFloatTrackContainer AdditionalTracks { get; set; }
		[Ordinal(7)]  [RED("motionExtraction")] public CHandle<animIMotionExtraction> MotionExtraction { get; set; }
		[Ordinal(8)]  [RED("frameClamping")] public CBool FrameClamping { get; set; }
		[Ordinal(9)]  [RED("frameClampingStartFrame")] public CInt8 FrameClampingStartFrame { get; set; }
		[Ordinal(10)]  [RED("frameClampingEndFrame")] public CInt8 FrameClampingEndFrame { get; set; }

		public animAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
