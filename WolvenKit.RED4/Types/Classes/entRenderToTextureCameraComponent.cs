using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRenderToTextureCameraComponent : entBaseCameraComponent
	{
		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("dynamicTextureRes")] 
		public CResourceAsyncReference<DynamicTexture> DynamicTextureRes
		{
			get => GetPropertyValue<CResourceAsyncReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<DynamicTexture>>(value);
		}

		[Ordinal(13)] 
		[RED("depthDynamicTextureRes")] 
		public CResourceReference<DynamicTexture> DepthDynamicTextureRes
		{
			get => GetPropertyValue<CResourceReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceReference<DynamicTexture>>(value);
		}

		[Ordinal(14)] 
		[RED("albedoDynamicTextureRes")] 
		public CResourceReference<DynamicTexture> AlbedoDynamicTextureRes
		{
			get => GetPropertyValue<CResourceReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceReference<DynamicTexture>>(value);
		}

		[Ordinal(15)] 
		[RED("normalsDynamicTextureRes")] 
		public CResourceReference<DynamicTexture> NormalsDynamicTextureRes
		{
			get => GetPropertyValue<CResourceReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceReference<DynamicTexture>>(value);
		}

		[Ordinal(16)] 
		[RED("particlesDynamicTextureRes")] 
		public CResourceReference<DynamicTexture> ParticlesDynamicTextureRes
		{
			get => GetPropertyValue<CResourceReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceReference<DynamicTexture>>(value);
		}

		[Ordinal(17)] 
		[RED("resolutionWidth")] 
		public CUInt32 ResolutionWidth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("resolutionHeight")] 
		public CUInt32 ResolutionHeight
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("aspectRatio")] 
		public CFloat AspectRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("env")] 
		public CResourceReference<worldEnvironmentAreaParameters> Env
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>(value);
		}

		[Ordinal(21)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		[Ordinal(22)] 
		[RED("renderingMode")] 
		public CEnum<entRenderToTextureMode> RenderingMode
		{
			get => GetPropertyValue<CEnum<entRenderToTextureMode>>();
			set => SetPropertyValue<CEnum<entRenderToTextureMode>>(value);
		}

		[Ordinal(23)] 
		[RED("depthCutDistance")] 
		public CFloat DepthCutDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(25)] 
		[RED("overrideBackgroundColor")] 
		public CBool OverrideBackgroundColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get => GetPropertyValue<CEnum<RenderSceneLayer>>();
			set => SetPropertyValue<CEnum<RenderSceneLayer>>(value);
		}

		[Ordinal(27)] 
		[RED("features")] 
		public entRenderToTextureFeatures Features
		{
			get => GetPropertyValue<entRenderToTextureFeatures>();
			set => SetPropertyValue<entRenderToTextureFeatures>(value);
		}

		[Ordinal(28)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entRenderToTextureCameraComponent()
		{
			NearPlaneOverride = 0.100000F;
			FarPlaneOverride = 1000.000000F;
			VirtualCameraName = "Component";
			ResolutionWidth = 100;
			ResolutionHeight = 100;
			Params = new WorldRenderAreaSettings { AreaParameters = new() };
			BackgroundColor = new CColor();
			Features = new entRenderToTextureFeatures { RenderDecals = true, RenderParticles = true, AntiAliasing = true, LocalShadows = true };
			StreamingDistance = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
