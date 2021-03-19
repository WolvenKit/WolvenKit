using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureCameraComponent : entBaseCameraComponent
	{
		private CBool _isEnabled;
		private CName _virtualCameraName;
		private raRef<DynamicTexture> _dynamicTextureRes;
		private rRef<DynamicTexture> _depthDynamicTextureRes;
		private rRef<DynamicTexture> _albedoDynamicTextureRes;
		private rRef<DynamicTexture> _normalsDynamicTextureRes;
		private rRef<DynamicTexture> _particlesDynamicTextureRes;
		private CUInt32 _resolutionWidth;
		private CUInt32 _resolutionHeight;
		private CFloat _aspectRatio;
		private rRef<worldEnvironmentAreaParameters> _env;
		private WorldRenderAreaSettings _params;
		private CEnum<entRenderToTextureMode> _renderingMode;
		private CFloat _depthCutDistance;
		private CColor _backgroundColor;
		private CBool _overrideBackgroundColor;
		private CEnum<RenderSceneLayer> _renderSceneLayer;
		private entRenderToTextureFeatures _features;
		private CFloat _streamingDistance;

		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(11)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get => GetProperty(ref _virtualCameraName);
			set => SetProperty(ref _virtualCameraName, value);
		}

		[Ordinal(12)] 
		[RED("dynamicTextureRes")] 
		public raRef<DynamicTexture> DynamicTextureRes
		{
			get => GetProperty(ref _dynamicTextureRes);
			set => SetProperty(ref _dynamicTextureRes, value);
		}

		[Ordinal(13)] 
		[RED("depthDynamicTextureRes")] 
		public rRef<DynamicTexture> DepthDynamicTextureRes
		{
			get => GetProperty(ref _depthDynamicTextureRes);
			set => SetProperty(ref _depthDynamicTextureRes, value);
		}

		[Ordinal(14)] 
		[RED("albedoDynamicTextureRes")] 
		public rRef<DynamicTexture> AlbedoDynamicTextureRes
		{
			get => GetProperty(ref _albedoDynamicTextureRes);
			set => SetProperty(ref _albedoDynamicTextureRes, value);
		}

		[Ordinal(15)] 
		[RED("normalsDynamicTextureRes")] 
		public rRef<DynamicTexture> NormalsDynamicTextureRes
		{
			get => GetProperty(ref _normalsDynamicTextureRes);
			set => SetProperty(ref _normalsDynamicTextureRes, value);
		}

		[Ordinal(16)] 
		[RED("particlesDynamicTextureRes")] 
		public rRef<DynamicTexture> ParticlesDynamicTextureRes
		{
			get => GetProperty(ref _particlesDynamicTextureRes);
			set => SetProperty(ref _particlesDynamicTextureRes, value);
		}

		[Ordinal(17)] 
		[RED("resolutionWidth")] 
		public CUInt32 ResolutionWidth
		{
			get => GetProperty(ref _resolutionWidth);
			set => SetProperty(ref _resolutionWidth, value);
		}

		[Ordinal(18)] 
		[RED("resolutionHeight")] 
		public CUInt32 ResolutionHeight
		{
			get => GetProperty(ref _resolutionHeight);
			set => SetProperty(ref _resolutionHeight, value);
		}

		[Ordinal(19)] 
		[RED("aspectRatio")] 
		public CFloat AspectRatio
		{
			get => GetProperty(ref _aspectRatio);
			set => SetProperty(ref _aspectRatio, value);
		}

		[Ordinal(20)] 
		[RED("env")] 
		public rRef<worldEnvironmentAreaParameters> Env
		{
			get => GetProperty(ref _env);
			set => SetProperty(ref _env, value);
		}

		[Ordinal(21)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(22)] 
		[RED("renderingMode")] 
		public CEnum<entRenderToTextureMode> RenderingMode
		{
			get => GetProperty(ref _renderingMode);
			set => SetProperty(ref _renderingMode, value);
		}

		[Ordinal(23)] 
		[RED("depthCutDistance")] 
		public CFloat DepthCutDistance
		{
			get => GetProperty(ref _depthCutDistance);
			set => SetProperty(ref _depthCutDistance, value);
		}

		[Ordinal(24)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetProperty(ref _backgroundColor);
			set => SetProperty(ref _backgroundColor, value);
		}

		[Ordinal(25)] 
		[RED("overrideBackgroundColor")] 
		public CBool OverrideBackgroundColor
		{
			get => GetProperty(ref _overrideBackgroundColor);
			set => SetProperty(ref _overrideBackgroundColor, value);
		}

		[Ordinal(26)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get => GetProperty(ref _renderSceneLayer);
			set => SetProperty(ref _renderSceneLayer, value);
		}

		[Ordinal(27)] 
		[RED("features")] 
		public entRenderToTextureFeatures Features
		{
			get => GetProperty(ref _features);
			set => SetProperty(ref _features, value);
		}

		[Ordinal(28)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		public entRenderToTextureCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
