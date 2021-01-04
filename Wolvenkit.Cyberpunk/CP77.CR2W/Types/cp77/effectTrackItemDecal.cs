using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDecal : effectTrackItem
	{
		[Ordinal(0)]  [RED("additionalRotation")] public CFloat AdditionalRotation { get; set; }
		[Ordinal(1)]  [RED("atlasFrameEnd")] public CInt32 AtlasFrameEnd { get; set; }
		[Ordinal(2)]  [RED("atlasFrameStart")] public CInt32 AtlasFrameStart { get; set; }
		[Ordinal(3)]  [RED("decalRenderMode")] public CEnum<EDecalRenderMode> DecalRenderMode { get; set; }
		[Ordinal(4)]  [RED("emissiveScale")] public CHandle<IEvaluatorVector> EmissiveScale { get; set; }
		[Ordinal(5)]  [RED("fadeInTime")] public CFloat FadeInTime { get; set; }
		[Ordinal(6)]  [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
		[Ordinal(7)]  [RED("horizontalFlip")] public CBool HorizontalFlip { get; set; }
		[Ordinal(8)]  [RED("isAttached")] public CBool IsAttached { get; set; }
		[Ordinal(9)]  [RED("isStretchEnabled")] public CBool IsStretchEnabled { get; set; }
		[Ordinal(10)]  [RED("material")] public rRef<IMaterial> Material { get; set; }
		[Ordinal(11)]  [RED("normalThreshold")] public CFloat NormalThreshold { get; set; }
		[Ordinal(12)]  [RED("normalsBlendingMode")] public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode { get; set; }
		[Ordinal(13)]  [RED("orderPriority")] public CEnum<RenderDecalOrderPriority> OrderPriority { get; set; }
		[Ordinal(14)]  [RED("randomAtlasing")] public CBool RandomAtlasing { get; set; }
		[Ordinal(15)]  [RED("randomRotation")] public CBool RandomRotation { get; set; }
		[Ordinal(16)]  [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
		[Ordinal(17)]  [RED("surfaceType")] public CEnum<ERenderObjectType> SurfaceType { get; set; }
		[Ordinal(18)]  [RED("verticalFlip")] public CBool VerticalFlip { get; set; }

		public effectTrackItemDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
