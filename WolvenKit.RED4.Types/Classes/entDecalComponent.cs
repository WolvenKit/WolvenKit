using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDecalComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(9)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("aspectRatio")] 
		public CFloat AspectRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(14)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("orderNo")] 
		public CUInt16 OrderNo
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(18)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(19)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get => GetPropertyValue<CEnum<EDecalRenderMode>>();
			set => SetPropertyValue<CEnum<EDecalRenderMode>>(value);
		}

		[Ordinal(20)] 
		[RED("isStretchingEnabled")] 
		public CBool IsStretchingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get => GetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>();
			set => SetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>(value);
		}

		[Ordinal(22)] 
		[RED("shouldCollectWithRayTracing")] 
		public CBool ShouldCollectWithRayTracing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entDecalComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			Scale = 1.000000F;
			VisualScale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			Alpha = 1.000000F;
			NormalThreshold = 1.000000F;
			RoughnessScale = 1.000000F;
			ShouldCollectWithRayTracing = true;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
