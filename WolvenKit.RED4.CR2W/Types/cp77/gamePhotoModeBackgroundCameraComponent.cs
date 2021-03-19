using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundCameraComponent : entBaseCameraComponent
	{
		private CBool _isEnabled;
		private CName _virtualCameraName;
		private raRef<DynamicTexture> _dynamicTextureRes;
		private rRef<worldEnvironmentAreaParameters> _env;
		private WorldRenderAreaSettings _params;
		private CFloat _depthCutDistance;
		private CColor _backgroundColor;
		private CBool _overrideBackgroundColor;
		private CEnum<RenderSceneLayer> _renderSceneLayer;
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
		[RED("env")] 
		public rRef<worldEnvironmentAreaParameters> Env
		{
			get => GetProperty(ref _env);
			set => SetProperty(ref _env, value);
		}

		[Ordinal(14)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(15)] 
		[RED("depthCutDistance")] 
		public CFloat DepthCutDistance
		{
			get => GetProperty(ref _depthCutDistance);
			set => SetProperty(ref _depthCutDistance, value);
		}

		[Ordinal(16)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetProperty(ref _backgroundColor);
			set => SetProperty(ref _backgroundColor, value);
		}

		[Ordinal(17)] 
		[RED("overrideBackgroundColor")] 
		public CBool OverrideBackgroundColor
		{
			get => GetProperty(ref _overrideBackgroundColor);
			set => SetProperty(ref _overrideBackgroundColor, value);
		}

		[Ordinal(18)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get => GetProperty(ref _renderSceneLayer);
			set => SetProperty(ref _renderSceneLayer, value);
		}

		[Ordinal(19)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		public gamePhotoModeBackgroundCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
