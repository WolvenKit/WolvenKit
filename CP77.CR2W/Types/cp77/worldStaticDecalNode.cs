using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticDecalNode : worldNode
	{
		[Ordinal(0)]  [RED("alpha")] public CFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(2)]  [RED("decalNodeVersion")] public CUInt8 DecalNodeVersion { get; set; }
		[Ordinal(3)]  [RED("decalRenderMode")] public CEnum<EDecalRenderMode> DecalRenderMode { get; set; }
		[Ordinal(4)]  [RED("diffuseColorScale")] public HDRColor DiffuseColorScale { get; set; }
		[Ordinal(5)]  [RED("enableNormalTreshold")] public CBool EnableNormalTreshold { get; set; }
		[Ordinal(6)]  [RED("forcedAutoHideDistance")] public CFloat ForcedAutoHideDistance { get; set; }
		[Ordinal(7)]  [RED("horizontalFlip")] public CBool HorizontalFlip { get; set; }
		[Ordinal(8)]  [RED("isStretchingEnabled")] public CBool IsStretchingEnabled { get; set; }
		[Ordinal(9)]  [RED("material")] public raRef<IMaterial> Material { get; set; }
		[Ordinal(10)]  [RED("normalThreshold")] public CFloat NormalThreshold { get; set; }
		[Ordinal(11)]  [RED("normalsBlendingMode")] public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode { get; set; }
		[Ordinal(12)]  [RED("orderNo")] public CUInt16 OrderNo { get; set; }
		[Ordinal(13)]  [RED("roughnessScale")] public CFloat RoughnessScale { get; set; }
		[Ordinal(14)]  [RED("shouldCollectWithRayTracing")] public CBool ShouldCollectWithRayTracing { get; set; }
		[Ordinal(15)]  [RED("surfaceType")] public CEnum<ERenderObjectType> SurfaceType { get; set; }
		[Ordinal(16)]  [RED("verticalFlip")] public CBool VerticalFlip { get; set; }

		public worldStaticDecalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
