using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("sourceTransform")] public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform { get; set; }
		[Ordinal(3)] [RED("isSourceTransformResaved")] public CBool IsSourceTransformResaved { get; set; }
		[Ordinal(4)] [RED("sourceTransformIndex")] public animTransformIndex SourceTransformIndex { get; set; }
		[Ordinal(5)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(6)] [RED("posX")] public CBool PosX { get; set; }
		[Ordinal(7)] [RED("posY")] public CBool PosY { get; set; }
		[Ordinal(8)] [RED("posZ")] public CBool PosZ { get; set; }
		[Ordinal(9)] [RED("rotX")] public CBool RotX { get; set; }
		[Ordinal(10)] [RED("rotY")] public CBool RotY { get; set; }
		[Ordinal(11)] [RED("rotZ")] public CBool RotZ { get; set; }
		[Ordinal(12)] [RED("scaleX")] public CBool ScaleX { get; set; }
		[Ordinal(13)] [RED("scaleY")] public CBool ScaleY { get; set; }
		[Ordinal(14)] [RED("scaleZ")] public CBool ScaleZ { get; set; }
		[Ordinal(15)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(16)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_DirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
