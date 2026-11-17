using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticDecalNode : worldNode
	{
		[Ordinal(2)] 
		[RED("material")] 
		public CResourceAsyncReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceAsyncReference<IMaterial>>();
			set => SetPropertyValue<CResourceAsyncReference<IMaterial>>(value);
		}

		[Ordinal(3)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("diffuseColorScale")] 
		public HDRColor DiffuseColorScale
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(10)] 
		[RED("isStretchingEnabled")] 
		public CBool IsStretchingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("enableNormalTreshold")] 
		public CBool EnableNormalTreshold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("orderNo")] 
		public CUInt16 OrderNo
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(13)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(14)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get => GetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>();
			set => SetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>(value);
		}

		[Ordinal(15)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get => GetPropertyValue<CEnum<EDecalRenderMode>>();
			set => SetPropertyValue<CEnum<EDecalRenderMode>>(value);
		}

		[Ordinal(16)] 
		[RED("shouldCollectWithRayTracing")] 
		public CBool ShouldCollectWithRayTracing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("forcedAutoHideDistance")] 
		public CFloat ForcedAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("decalNodeVersion")] 
		public CUInt8 DecalNodeVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldStaticDecalNode()
		{
			AutoHideDistance = 20.000000F;
			Alpha = 1.000000F;
			NormalThreshold = 1.000000F;
			RoughnessScale = 1.000000F;
			DiffuseColorScale = new HDRColor { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			EnableNormalTreshold = true;
			ShouldCollectWithRayTracing = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
