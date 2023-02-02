using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemDecal : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("emissiveScale")] 
		public CHandle<IEvaluatorVector> EmissiveScale
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(6)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("randomAtlasing")] 
		public CBool RandomAtlasing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isStretchEnabled")] 
		public CBool IsStretchEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get => GetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>();
			set => SetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>(value);
		}

		[Ordinal(17)] 
		[RED("atlasFrameStart")] 
		public CInt32 AtlasFrameStart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("atlasFrameEnd")] 
		public CInt32 AtlasFrameEnd
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("orderPriority")] 
		public CEnum<RenderDecalOrderPriority> OrderPriority
		{
			get => GetPropertyValue<CEnum<RenderDecalOrderPriority>>();
			set => SetPropertyValue<CEnum<RenderDecalOrderPriority>>(value);
		}

		[Ordinal(20)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(21)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get => GetPropertyValue<CEnum<EDecalRenderMode>>();
			set => SetPropertyValue<CEnum<EDecalRenderMode>>(value);
		}

		public effectTrackItemDecal()
		{
			TimeDuration = 1.000000F;
			AtlasFrameStart = -1;
			AtlasFrameEnd = -1;
			OrderPriority = Enums.RenderDecalOrderPriority.Priority3;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
