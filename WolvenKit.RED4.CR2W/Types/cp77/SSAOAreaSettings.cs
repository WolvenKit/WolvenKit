using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSAOAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _noiseFilterTolerance;
		private curveData<CFloat> _blurTolerance;
		private curveData<CFloat> _upsampleTolerance;
		private curveData<CFloat> _rejectionFalloff;
		private CBool _combineResolutionsBeforeBlur;
		private CBool _combineResolutionsWithMul;
		private CBool _normalsEnable;
		private CInt32 _hierarchyDepth;
		private curveData<CFloat> _normalAOMultiply;
		private curveData<CFloat> _normalBackProjectTolerance;
		private CEnum<ESSAOQualityLevel> _qualityLevel;
		private curveData<CFloat> _coneAoDiffuseStrength;
		private curveData<CFloat> _coneAoSpecularStrength;
		private curveData<CFloat> _coneAoSpecularTreshold;
		private curveData<CFloat> _lightAoDiffuseStrength;
		private curveData<CFloat> _lightAoSpecularStrength;
		private curveData<CFloat> _foliageDimDiffuse;
		private curveData<CFloat> _foliageDimSpecular;

		[Ordinal(2)] 
		[RED("noiseFilterTolerance")] 
		public curveData<CFloat> NoiseFilterTolerance
		{
			get => GetProperty(ref _noiseFilterTolerance);
			set => SetProperty(ref _noiseFilterTolerance, value);
		}

		[Ordinal(3)] 
		[RED("blurTolerance")] 
		public curveData<CFloat> BlurTolerance
		{
			get => GetProperty(ref _blurTolerance);
			set => SetProperty(ref _blurTolerance, value);
		}

		[Ordinal(4)] 
		[RED("upsampleTolerance")] 
		public curveData<CFloat> UpsampleTolerance
		{
			get => GetProperty(ref _upsampleTolerance);
			set => SetProperty(ref _upsampleTolerance, value);
		}

		[Ordinal(5)] 
		[RED("rejectionFalloff")] 
		public curveData<CFloat> RejectionFalloff
		{
			get => GetProperty(ref _rejectionFalloff);
			set => SetProperty(ref _rejectionFalloff, value);
		}

		[Ordinal(6)] 
		[RED("combineResolutionsBeforeBlur")] 
		public CBool CombineResolutionsBeforeBlur
		{
			get => GetProperty(ref _combineResolutionsBeforeBlur);
			set => SetProperty(ref _combineResolutionsBeforeBlur, value);
		}

		[Ordinal(7)] 
		[RED("combineResolutionsWithMul")] 
		public CBool CombineResolutionsWithMul
		{
			get => GetProperty(ref _combineResolutionsWithMul);
			set => SetProperty(ref _combineResolutionsWithMul, value);
		}

		[Ordinal(8)] 
		[RED("normalsEnable")] 
		public CBool NormalsEnable
		{
			get => GetProperty(ref _normalsEnable);
			set => SetProperty(ref _normalsEnable, value);
		}

		[Ordinal(9)] 
		[RED("hierarchyDepth")] 
		public CInt32 HierarchyDepth
		{
			get => GetProperty(ref _hierarchyDepth);
			set => SetProperty(ref _hierarchyDepth, value);
		}

		[Ordinal(10)] 
		[RED("normalAOMultiply")] 
		public curveData<CFloat> NormalAOMultiply
		{
			get => GetProperty(ref _normalAOMultiply);
			set => SetProperty(ref _normalAOMultiply, value);
		}

		[Ordinal(11)] 
		[RED("normalBackProjectTolerance")] 
		public curveData<CFloat> NormalBackProjectTolerance
		{
			get => GetProperty(ref _normalBackProjectTolerance);
			set => SetProperty(ref _normalBackProjectTolerance, value);
		}

		[Ordinal(12)] 
		[RED("qualityLevel")] 
		public CEnum<ESSAOQualityLevel> QualityLevel
		{
			get => GetProperty(ref _qualityLevel);
			set => SetProperty(ref _qualityLevel, value);
		}

		[Ordinal(13)] 
		[RED("coneAoDiffuseStrength")] 
		public curveData<CFloat> ConeAoDiffuseStrength
		{
			get => GetProperty(ref _coneAoDiffuseStrength);
			set => SetProperty(ref _coneAoDiffuseStrength, value);
		}

		[Ordinal(14)] 
		[RED("coneAoSpecularStrength")] 
		public curveData<CFloat> ConeAoSpecularStrength
		{
			get => GetProperty(ref _coneAoSpecularStrength);
			set => SetProperty(ref _coneAoSpecularStrength, value);
		}

		[Ordinal(15)] 
		[RED("coneAoSpecularTreshold")] 
		public curveData<CFloat> ConeAoSpecularTreshold
		{
			get => GetProperty(ref _coneAoSpecularTreshold);
			set => SetProperty(ref _coneAoSpecularTreshold, value);
		}

		[Ordinal(16)] 
		[RED("lightAoDiffuseStrength")] 
		public curveData<CFloat> LightAoDiffuseStrength
		{
			get => GetProperty(ref _lightAoDiffuseStrength);
			set => SetProperty(ref _lightAoDiffuseStrength, value);
		}

		[Ordinal(17)] 
		[RED("lightAoSpecularStrength")] 
		public curveData<CFloat> LightAoSpecularStrength
		{
			get => GetProperty(ref _lightAoSpecularStrength);
			set => SetProperty(ref _lightAoSpecularStrength, value);
		}

		[Ordinal(18)] 
		[RED("foliageDimDiffuse")] 
		public curveData<CFloat> FoliageDimDiffuse
		{
			get => GetProperty(ref _foliageDimDiffuse);
			set => SetProperty(ref _foliageDimDiffuse, value);
		}

		[Ordinal(19)] 
		[RED("foliageDimSpecular")] 
		public curveData<CFloat> FoliageDimSpecular
		{
			get => GetProperty(ref _foliageDimSpecular);
			set => SetProperty(ref _foliageDimSpecular, value);
		}

		public SSAOAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
