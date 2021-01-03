using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entDecalComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("alpha")] public CFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("aspectRatio")] public CFloat AspectRatio { get; set; }
		[Ordinal(2)]  [RED("decalRenderMode")] public CEnum<EDecalRenderMode> DecalRenderMode { get; set; }
		[Ordinal(3)]  [RED("horizontalFlip")] public CBool HorizontalFlip { get; set; }
		[Ordinal(4)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(5)]  [RED("isStretchingEnabled")] public CBool IsStretchingEnabled { get; set; }
		[Ordinal(6)]  [RED("material")] public rRef<IMaterial> Material { get; set; }
		[Ordinal(7)]  [RED("normalThreshold")] public CFloat NormalThreshold { get; set; }
		[Ordinal(8)]  [RED("normalsBlendingMode")] public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode { get; set; }
		[Ordinal(9)]  [RED("orderNo")] public CUInt16 OrderNo { get; set; }
		[Ordinal(10)]  [RED("roughnessScale")] public CFloat RoughnessScale { get; set; }
		[Ordinal(11)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(12)]  [RED("shouldCollectWithRayTracing")] public CBool ShouldCollectWithRayTracing { get; set; }
		[Ordinal(13)]  [RED("surfaceType")] public CEnum<ERenderObjectType> SurfaceType { get; set; }
		[Ordinal(14)]  [RED("verticalFlip")] public CBool VerticalFlip { get; set; }
		[Ordinal(15)]  [RED("visualScale")] public Vector3 VisualScale { get; set; }

		public entDecalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
