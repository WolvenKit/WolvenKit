using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSAOAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("noiseFilterTolerance")] 
		public CLegacySingleChannelCurve<CFloat> NoiseFilterTolerance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("blurTolerance")] 
		public CLegacySingleChannelCurve<CFloat> BlurTolerance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("upsampleTolerance")] 
		public CLegacySingleChannelCurve<CFloat> UpsampleTolerance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("rejectionFalloff")] 
		public CLegacySingleChannelCurve<CFloat> RejectionFalloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("combineResolutionsBeforeBlur")] 
		public CBool CombineResolutionsBeforeBlur
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("combineResolutionsWithMul")] 
		public CBool CombineResolutionsWithMul
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("normalsEnable")] 
		public CBool NormalsEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("hierarchyDepth")] 
		public CInt32 HierarchyDepth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("normalAOMultiply")] 
		public CLegacySingleChannelCurve<CFloat> NormalAOMultiply
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("normalBackProjectTolerance")] 
		public CLegacySingleChannelCurve<CFloat> NormalBackProjectTolerance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("qualityLevel")] 
		public CEnum<ESSAOQualityLevel> QualityLevel
		{
			get => GetPropertyValue<CEnum<ESSAOQualityLevel>>();
			set => SetPropertyValue<CEnum<ESSAOQualityLevel>>(value);
		}

		[Ordinal(13)] 
		[RED("coneAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoDiffuseStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(14)] 
		[RED("coneAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("coneAoSpecularTreshold")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularTreshold
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(16)] 
		[RED("lightAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoDiffuseStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("lightAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoSpecularStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(18)] 
		[RED("foliageDimDiffuse")] 
		public CLegacySingleChannelCurve<CFloat> FoliageDimDiffuse
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("foliageDimSpecular")] 
		public CLegacySingleChannelCurve<CFloat> FoliageDimSpecular
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public SSAOAreaSettings()
		{
			Enable = true;
			CombineResolutionsBeforeBlur = true;
			CombineResolutionsWithMul = true;
			NormalsEnable = true;
			HierarchyDepth = 3;
			QualityLevel = Enums.ESSAOQualityLevel.SSAOQUALITY_VeryHigh;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
