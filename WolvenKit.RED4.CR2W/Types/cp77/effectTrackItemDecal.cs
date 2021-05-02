using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDecal : effectTrackItem
	{
		private rRef<IMaterial> _material;
		private CHandle<IEvaluatorVector> _scale;
		private CHandle<IEvaluatorVector> _emissiveScale;
		private CFloat _normalThreshold;
		private CBool _horizontalFlip;
		private CBool _verticalFlip;
		private CFloat _fadeOutTime;
		private CFloat _fadeInTime;
		private CFloat _additionalRotation;
		private CBool _randomRotation;
		private CBool _randomAtlasing;
		private CBool _isStretchEnabled;
		private CBool _isAttached;
		private CEnum<RenderDecalNormalsBlendingMode> _normalsBlendingMode;
		private CInt32 _atlasFrameStart;
		private CInt32 _atlasFrameEnd;
		private CEnum<RenderDecalOrderPriority> _orderPriority;
		private CEnum<ERenderObjectType> _surfaceType;
		private CEnum<EDecalRenderMode> _decalRenderMode;

		[Ordinal(3)] 
		[RED("material")] 
		public rRef<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(5)] 
		[RED("emissiveScale")] 
		public CHandle<IEvaluatorVector> EmissiveScale
		{
			get => GetProperty(ref _emissiveScale);
			set => SetProperty(ref _emissiveScale, value);
		}

		[Ordinal(6)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetProperty(ref _normalThreshold);
			set => SetProperty(ref _normalThreshold, value);
		}

		[Ordinal(7)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get => GetProperty(ref _horizontalFlip);
			set => SetProperty(ref _horizontalFlip, value);
		}

		[Ordinal(8)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get => GetProperty(ref _verticalFlip);
			set => SetProperty(ref _verticalFlip, value);
		}

		[Ordinal(9)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetProperty(ref _fadeOutTime);
			set => SetProperty(ref _fadeOutTime, value);
		}

		[Ordinal(10)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get => GetProperty(ref _fadeInTime);
			set => SetProperty(ref _fadeInTime, value);
		}

		[Ordinal(11)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get => GetProperty(ref _additionalRotation);
			set => SetProperty(ref _additionalRotation, value);
		}

		[Ordinal(12)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get => GetProperty(ref _randomRotation);
			set => SetProperty(ref _randomRotation, value);
		}

		[Ordinal(13)] 
		[RED("randomAtlasing")] 
		public CBool RandomAtlasing
		{
			get => GetProperty(ref _randomAtlasing);
			set => SetProperty(ref _randomAtlasing, value);
		}

		[Ordinal(14)] 
		[RED("isStretchEnabled")] 
		public CBool IsStretchEnabled
		{
			get => GetProperty(ref _isStretchEnabled);
			set => SetProperty(ref _isStretchEnabled, value);
		}

		[Ordinal(15)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get => GetProperty(ref _isAttached);
			set => SetProperty(ref _isAttached, value);
		}

		[Ordinal(16)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get => GetProperty(ref _normalsBlendingMode);
			set => SetProperty(ref _normalsBlendingMode, value);
		}

		[Ordinal(17)] 
		[RED("atlasFrameStart")] 
		public CInt32 AtlasFrameStart
		{
			get => GetProperty(ref _atlasFrameStart);
			set => SetProperty(ref _atlasFrameStart, value);
		}

		[Ordinal(18)] 
		[RED("atlasFrameEnd")] 
		public CInt32 AtlasFrameEnd
		{
			get => GetProperty(ref _atlasFrameEnd);
			set => SetProperty(ref _atlasFrameEnd, value);
		}

		[Ordinal(19)] 
		[RED("orderPriority")] 
		public CEnum<RenderDecalOrderPriority> OrderPriority
		{
			get => GetProperty(ref _orderPriority);
			set => SetProperty(ref _orderPriority, value);
		}

		[Ordinal(20)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get => GetProperty(ref _surfaceType);
			set => SetProperty(ref _surfaceType, value);
		}

		[Ordinal(21)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get => GetProperty(ref _decalRenderMode);
			set => SetProperty(ref _decalRenderMode, value);
		}

		public effectTrackItemDecal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
