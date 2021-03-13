using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("sourceTransform")] public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform { get; set; }
		[Ordinal(13)] [RED("isSourceTransformResaved")] public CBool IsSourceTransformResaved { get; set; }
		[Ordinal(14)] [RED("sourceTransformIndex")] public animTransformIndex SourceTransformIndex { get; set; }
		[Ordinal(15)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(16)] [RED("posX")] public CBool PosX { get; set; }
		[Ordinal(17)] [RED("posY")] public CBool PosY { get; set; }
		[Ordinal(18)] [RED("posZ")] public CBool PosZ { get; set; }
		[Ordinal(19)] [RED("rotX")] public CBool RotX { get; set; }
		[Ordinal(20)] [RED("rotY")] public CBool RotY { get; set; }
		[Ordinal(21)] [RED("rotZ")] public CBool RotZ { get; set; }
		[Ordinal(22)] [RED("scaleX")] public CBool ScaleX { get; set; }
		[Ordinal(23)] [RED("scaleY")] public CBool ScaleY { get; set; }
		[Ordinal(24)] [RED("scaleZ")] public CBool ScaleZ { get; set; }
		[Ordinal(25)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(26)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_DirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
