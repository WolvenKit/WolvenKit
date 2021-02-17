using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entDecalComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("material")] public rRef<IMaterial> Material { get; set; }
		[Ordinal(9)] [RED("verticalFlip")] public CBool VerticalFlip { get; set; }
		[Ordinal(10)] [RED("horizontalFlip")] public CBool HorizontalFlip { get; set; }
		[Ordinal(11)] [RED("aspectRatio")] public CFloat AspectRatio { get; set; }
		[Ordinal(12)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(13)] [RED("visualScale")] public Vector3 VisualScale { get; set; }
		[Ordinal(14)] [RED("alpha")] public CFloat Alpha { get; set; }
		[Ordinal(15)] [RED("normalThreshold")] public CFloat NormalThreshold { get; set; }
		[Ordinal(16)] [RED("roughnessScale")] public CFloat RoughnessScale { get; set; }
		[Ordinal(17)] [RED("orderNo")] public CUInt16 OrderNo { get; set; }
		[Ordinal(18)] [RED("surfaceType")] public CEnum<ERenderObjectType> SurfaceType { get; set; }
		[Ordinal(19)] [RED("decalRenderMode")] public CEnum<EDecalRenderMode> DecalRenderMode { get; set; }
		[Ordinal(20)] [RED("isStretchingEnabled")] public CBool IsStretchingEnabled { get; set; }
		[Ordinal(21)] [RED("normalsBlendingMode")] public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode { get; set; }
		[Ordinal(22)] [RED("shouldCollectWithRayTracing")] public CBool ShouldCollectWithRayTracing { get; set; }
		[Ordinal(23)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entDecalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
