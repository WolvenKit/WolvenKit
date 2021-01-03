using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformToTrack : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("channel")] public CEnum<animTransformChannel> Channel { get; set; }
		[Ordinal(1)]  [RED("floatTrack")] public CInt32 FloatTrack { get; set; }
		[Ordinal(2)]  [RED("floatTrackIndex")] public animNamedTrackIndex FloatTrackIndex { get; set; }
		[Ordinal(3)]  [RED("mulFactor")] public CFloat MulFactor { get; set; }
		[Ordinal(4)]  [RED("mulFactorNode")] public animFloatLink MulFactorNode { get; set; }
		[Ordinal(5)]  [RED("outputTransform")] public CInt16 OutputTransform { get; set; }
		[Ordinal(6)]  [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(7)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(8)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_TransformToTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
