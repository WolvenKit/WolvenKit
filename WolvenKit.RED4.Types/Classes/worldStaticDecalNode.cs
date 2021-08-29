using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticDecalNode : worldNode
	{
		private CResourceAsyncReference<IMaterial> _material;
		private CFloat _autoHideDistance;
		private CBool _verticalFlip;
		private CBool _horizontalFlip;
		private CFloat _alpha;
		private CFloat _normalThreshold;
		private CFloat _roughnessScale;
		private HDRColor _diffuseColorScale;
		private CBool _isStretchingEnabled;
		private CBool _enableNormalTreshold;
		private CUInt16 _orderNo;
		private CEnum<ERenderObjectType> _surfaceType;
		private CEnum<RenderDecalNormalsBlendingMode> _normalsBlendingMode;
		private CEnum<EDecalRenderMode> _decalRenderMode;
		private CBool _shouldCollectWithRayTracing;
		private CFloat _forcedAutoHideDistance;
		private CUInt8 _decalNodeVersion;

		[Ordinal(4)] 
		[RED("material")] 
		public CResourceAsyncReference<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(5)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetProperty(ref _autoHideDistance);
			set => SetProperty(ref _autoHideDistance, value);
		}

		[Ordinal(6)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get => GetProperty(ref _verticalFlip);
			set => SetProperty(ref _verticalFlip, value);
		}

		[Ordinal(7)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get => GetProperty(ref _horizontalFlip);
			set => SetProperty(ref _horizontalFlip, value);
		}

		[Ordinal(8)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		[Ordinal(9)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetProperty(ref _normalThreshold);
			set => SetProperty(ref _normalThreshold, value);
		}

		[Ordinal(10)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get => GetProperty(ref _roughnessScale);
			set => SetProperty(ref _roughnessScale, value);
		}

		[Ordinal(11)] 
		[RED("diffuseColorScale")] 
		public HDRColor DiffuseColorScale
		{
			get => GetProperty(ref _diffuseColorScale);
			set => SetProperty(ref _diffuseColorScale, value);
		}

		[Ordinal(12)] 
		[RED("isStretchingEnabled")] 
		public CBool IsStretchingEnabled
		{
			get => GetProperty(ref _isStretchingEnabled);
			set => SetProperty(ref _isStretchingEnabled, value);
		}

		[Ordinal(13)] 
		[RED("enableNormalTreshold")] 
		public CBool EnableNormalTreshold
		{
			get => GetProperty(ref _enableNormalTreshold);
			set => SetProperty(ref _enableNormalTreshold, value);
		}

		[Ordinal(14)] 
		[RED("orderNo")] 
		public CUInt16 OrderNo
		{
			get => GetProperty(ref _orderNo);
			set => SetProperty(ref _orderNo, value);
		}

		[Ordinal(15)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get => GetProperty(ref _surfaceType);
			set => SetProperty(ref _surfaceType, value);
		}

		[Ordinal(16)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get => GetProperty(ref _normalsBlendingMode);
			set => SetProperty(ref _normalsBlendingMode, value);
		}

		[Ordinal(17)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get => GetProperty(ref _decalRenderMode);
			set => SetProperty(ref _decalRenderMode, value);
		}

		[Ordinal(18)] 
		[RED("shouldCollectWithRayTracing")] 
		public CBool ShouldCollectWithRayTracing
		{
			get => GetProperty(ref _shouldCollectWithRayTracing);
			set => SetProperty(ref _shouldCollectWithRayTracing, value);
		}

		[Ordinal(19)] 
		[RED("forcedAutoHideDistance")] 
		public CFloat ForcedAutoHideDistance
		{
			get => GetProperty(ref _forcedAutoHideDistance);
			set => SetProperty(ref _forcedAutoHideDistance, value);
		}

		[Ordinal(20)] 
		[RED("decalNodeVersion")] 
		public CUInt8 DecalNodeVersion
		{
			get => GetProperty(ref _decalNodeVersion);
			set => SetProperty(ref _decalNodeVersion, value);
		}
	}
}
