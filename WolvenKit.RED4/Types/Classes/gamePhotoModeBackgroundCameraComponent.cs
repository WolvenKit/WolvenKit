using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePhotoModeBackgroundCameraComponent : entBaseCameraComponent
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
		[RED("env")] 
		public CResourceReference<worldEnvironmentAreaParameters> Env
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>(value);
		}

		[Ordinal(14)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		[Ordinal(15)] 
		[RED("depthCutDistance")] 
		public CFloat DepthCutDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(17)] 
		[RED("overrideBackgroundColor")] 
		public CBool OverrideBackgroundColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get => GetPropertyValue<CEnum<RenderSceneLayer>>();
			set => SetPropertyValue<CEnum<RenderSceneLayer>>(value);
		}

		[Ordinal(19)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamePhotoModeBackgroundCameraComponent()
		{
			NearPlaneOverride = 0.100000F;
			FarPlaneOverride = 1000.000000F;
			VirtualCameraName = "Component";
			Params = new() { AreaParameters = new() };
			BackgroundColor = new();
			StreamingDistance = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
