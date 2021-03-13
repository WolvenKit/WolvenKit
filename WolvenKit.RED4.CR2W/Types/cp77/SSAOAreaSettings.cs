using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSAOAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("noiseFilterTolerance")] public curveData<CFloat> NoiseFilterTolerance { get; set; }
		[Ordinal(3)] [RED("blurTolerance")] public curveData<CFloat> BlurTolerance { get; set; }
		[Ordinal(4)] [RED("upsampleTolerance")] public curveData<CFloat> UpsampleTolerance { get; set; }
		[Ordinal(5)] [RED("rejectionFalloff")] public curveData<CFloat> RejectionFalloff { get; set; }
		[Ordinal(6)] [RED("combineResolutionsBeforeBlur")] public CBool CombineResolutionsBeforeBlur { get; set; }
		[Ordinal(7)] [RED("combineResolutionsWithMul")] public CBool CombineResolutionsWithMul { get; set; }
		[Ordinal(8)] [RED("normalsEnable")] public CBool NormalsEnable { get; set; }
		[Ordinal(9)] [RED("hierarchyDepth")] public CInt32 HierarchyDepth { get; set; }
		[Ordinal(10)] [RED("normalAOMultiply")] public curveData<CFloat> NormalAOMultiply { get; set; }
		[Ordinal(11)] [RED("normalBackProjectTolerance")] public curveData<CFloat> NormalBackProjectTolerance { get; set; }
		[Ordinal(12)] [RED("qualityLevel")] public CEnum<ESSAOQualityLevel> QualityLevel { get; set; }
		[Ordinal(13)] [RED("coneAoDiffuseStrength")] public curveData<CFloat> ConeAoDiffuseStrength { get; set; }
		[Ordinal(14)] [RED("coneAoSpecularStrength")] public curveData<CFloat> ConeAoSpecularStrength { get; set; }
		[Ordinal(15)] [RED("coneAoSpecularTreshold")] public curveData<CFloat> ConeAoSpecularTreshold { get; set; }
		[Ordinal(16)] [RED("lightAoDiffuseStrength")] public curveData<CFloat> LightAoDiffuseStrength { get; set; }
		[Ordinal(17)] [RED("lightAoSpecularStrength")] public curveData<CFloat> LightAoSpecularStrength { get; set; }
		[Ordinal(18)] [RED("foliageDimDiffuse")] public curveData<CFloat> FoliageDimDiffuse { get; set; }
		[Ordinal(19)] [RED("foliageDimSpecular")] public curveData<CFloat> FoliageDimSpecular { get; set; }

		public SSAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
