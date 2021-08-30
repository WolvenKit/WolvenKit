using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDecalComponent : entIVisualComponent
	{
		private CResourceReference<IMaterial> _material;
		private CBool _verticalFlip;
		private CBool _horizontalFlip;
		private CFloat _aspectRatio;
		private CFloat _scale;
		private Vector3 _visualScale;
		private CFloat _alpha;
		private CFloat _normalThreshold;
		private CFloat _roughnessScale;
		private CUInt16 _orderNo;
		private CEnum<ERenderObjectType> _surfaceType;
		private CEnum<EDecalRenderMode> _decalRenderMode;
		private CBool _isStretchingEnabled;
		private CEnum<RenderDecalNormalsBlendingMode> _normalsBlendingMode;
		private CBool _shouldCollectWithRayTracing;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(9)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get => GetProperty(ref _verticalFlip);
			set => SetProperty(ref _verticalFlip, value);
		}

		[Ordinal(10)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get => GetProperty(ref _horizontalFlip);
			set => SetProperty(ref _horizontalFlip, value);
		}

		[Ordinal(11)] 
		[RED("aspectRatio")] 
		public CFloat AspectRatio
		{
			get => GetProperty(ref _aspectRatio);
			set => SetProperty(ref _aspectRatio, value);
		}

		[Ordinal(12)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(13)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get => GetProperty(ref _visualScale);
			set => SetProperty(ref _visualScale, value);
		}

		[Ordinal(14)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		[Ordinal(15)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetProperty(ref _normalThreshold);
			set => SetProperty(ref _normalThreshold, value);
		}

		[Ordinal(16)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get => GetProperty(ref _roughnessScale);
			set => SetProperty(ref _roughnessScale, value);
		}

		[Ordinal(17)] 
		[RED("orderNo")] 
		public CUInt16 OrderNo
		{
			get => GetProperty(ref _orderNo);
			set => SetProperty(ref _orderNo, value);
		}

		[Ordinal(18)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get => GetProperty(ref _surfaceType);
			set => SetProperty(ref _surfaceType, value);
		}

		[Ordinal(19)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get => GetProperty(ref _decalRenderMode);
			set => SetProperty(ref _decalRenderMode, value);
		}

		[Ordinal(20)] 
		[RED("isStretchingEnabled")] 
		public CBool IsStretchingEnabled
		{
			get => GetProperty(ref _isStretchingEnabled);
			set => SetProperty(ref _isStretchingEnabled, value);
		}

		[Ordinal(21)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get => GetProperty(ref _normalsBlendingMode);
			set => SetProperty(ref _normalsBlendingMode, value);
		}

		[Ordinal(22)] 
		[RED("shouldCollectWithRayTracing")] 
		public CBool ShouldCollectWithRayTracing
		{
			get => GetProperty(ref _shouldCollectWithRayTracing);
			set => SetProperty(ref _shouldCollectWithRayTracing, value);
		}

		[Ordinal(23)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public entDecalComponent()
		{
			_scale = 1.000000F;
			_alpha = 1.000000F;
			_normalThreshold = 1.000000F;
			_roughnessScale = 1.000000F;
			_shouldCollectWithRayTracing = true;
			_isEnabled = true;
		}
	}
}
