using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SSAOAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _noiseFilterTolerance;
		private CLegacySingleChannelCurve<CFloat> _blurTolerance;
		private CLegacySingleChannelCurve<CFloat> _upsampleTolerance;
		private CLegacySingleChannelCurve<CFloat> _rejectionFalloff;
		private CBool _combineResolutionsBeforeBlur;
		private CBool _combineResolutionsWithMul;
		private CBool _normalsEnable;
		private CInt32 _hierarchyDepth;
		private CLegacySingleChannelCurve<CFloat> _normalAOMultiply;
		private CLegacySingleChannelCurve<CFloat> _normalBackProjectTolerance;
		private CEnum<ESSAOQualityLevel> _qualityLevel;
		private CLegacySingleChannelCurve<CFloat> _coneAoDiffuseStrength;
		private CLegacySingleChannelCurve<CFloat> _coneAoSpecularStrength;
		private CLegacySingleChannelCurve<CFloat> _coneAoSpecularTreshold;
		private CLegacySingleChannelCurve<CFloat> _lightAoDiffuseStrength;
		private CLegacySingleChannelCurve<CFloat> _lightAoSpecularStrength;
		private CLegacySingleChannelCurve<CFloat> _foliageDimDiffuse;
		private CLegacySingleChannelCurve<CFloat> _foliageDimSpecular;

		[Ordinal(2)] 
		[RED("noiseFilterTolerance")] 
		public CLegacySingleChannelCurve<CFloat> NoiseFilterTolerance
		{
			get => GetProperty(ref _noiseFilterTolerance);
			set => SetProperty(ref _noiseFilterTolerance, value);
		}

		[Ordinal(3)] 
		[RED("blurTolerance")] 
		public CLegacySingleChannelCurve<CFloat> BlurTolerance
		{
			get => GetProperty(ref _blurTolerance);
			set => SetProperty(ref _blurTolerance, value);
		}

		[Ordinal(4)] 
		[RED("upsampleTolerance")] 
		public CLegacySingleChannelCurve<CFloat> UpsampleTolerance
		{
			get => GetProperty(ref _upsampleTolerance);
			set => SetProperty(ref _upsampleTolerance, value);
		}

		[Ordinal(5)] 
		[RED("rejectionFalloff")] 
		public CLegacySingleChannelCurve<CFloat> RejectionFalloff
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
		public CLegacySingleChannelCurve<CFloat> NormalAOMultiply
		{
			get => GetProperty(ref _normalAOMultiply);
			set => SetProperty(ref _normalAOMultiply, value);
		}

		[Ordinal(11)] 
		[RED("normalBackProjectTolerance")] 
		public CLegacySingleChannelCurve<CFloat> NormalBackProjectTolerance
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
		public CLegacySingleChannelCurve<CFloat> ConeAoDiffuseStrength
		{
			get => GetProperty(ref _coneAoDiffuseStrength);
			set => SetProperty(ref _coneAoDiffuseStrength, value);
		}

		[Ordinal(14)] 
		[RED("coneAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularStrength
		{
			get => GetProperty(ref _coneAoSpecularStrength);
			set => SetProperty(ref _coneAoSpecularStrength, value);
		}

		[Ordinal(15)] 
		[RED("coneAoSpecularTreshold")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularTreshold
		{
			get => GetProperty(ref _coneAoSpecularTreshold);
			set => SetProperty(ref _coneAoSpecularTreshold, value);
		}

		[Ordinal(16)] 
		[RED("lightAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoDiffuseStrength
		{
			get => GetProperty(ref _lightAoDiffuseStrength);
			set => SetProperty(ref _lightAoDiffuseStrength, value);
		}

		[Ordinal(17)] 
		[RED("lightAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoSpecularStrength
		{
			get => GetProperty(ref _lightAoSpecularStrength);
			set => SetProperty(ref _lightAoSpecularStrength, value);
		}

		[Ordinal(18)] 
		[RED("foliageDimDiffuse")] 
		public CLegacySingleChannelCurve<CFloat> FoliageDimDiffuse
		{
			get => GetProperty(ref _foliageDimDiffuse);
			set => SetProperty(ref _foliageDimDiffuse, value);
		}

		[Ordinal(19)] 
		[RED("foliageDimSpecular")] 
		public CLegacySingleChannelCurve<CFloat> FoliageDimSpecular
		{
			get => GetProperty(ref _foliageDimSpecular);
			set => SetProperty(ref _foliageDimSpecular, value);
		}

		public SSAOAreaSettings()
		{
			_combineResolutionsBeforeBlur = true;
			_combineResolutionsWithMul = true;
			_normalsEnable = true;
			_hierarchyDepth = 3;
			_qualityLevel = new() { Value = Enums.ESSAOQualityLevel.SSAOQUALITY_VeryHigh };
		}
	}
}
