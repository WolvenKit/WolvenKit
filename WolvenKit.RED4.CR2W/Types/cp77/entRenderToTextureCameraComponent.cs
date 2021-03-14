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
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get
			{
				if (_virtualCameraName == null)
				{
					_virtualCameraName = (CName) CR2WTypeManager.Create("CName", "virtualCameraName", cr2w, this);
				}
				return _virtualCameraName;
			}
			set
			{
				if (_virtualCameraName == value)
				{
					return;
				}
				_virtualCameraName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dynamicTextureRes")] 
		public raRef<DynamicTexture> DynamicTextureRes
		{
			get
			{
				if (_dynamicTextureRes == null)
				{
					_dynamicTextureRes = (raRef<DynamicTexture>) CR2WTypeManager.Create("raRef:DynamicTexture", "dynamicTextureRes", cr2w, this);
				}
				return _dynamicTextureRes;
			}
			set
			{
				if (_dynamicTextureRes == value)
				{
					return;
				}
				_dynamicTextureRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("depthDynamicTextureRes")] 
		public rRef<DynamicTexture> DepthDynamicTextureRes
		{
			get
			{
				if (_depthDynamicTextureRes == null)
				{
					_depthDynamicTextureRes = (rRef<DynamicTexture>) CR2WTypeManager.Create("rRef:DynamicTexture", "depthDynamicTextureRes", cr2w, this);
				}
				return _depthDynamicTextureRes;
			}
			set
			{
				if (_depthDynamicTextureRes == value)
				{
					return;
				}
				_depthDynamicTextureRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("albedoDynamicTextureRes")] 
		public rRef<DynamicTexture> AlbedoDynamicTextureRes
		{
			get
			{
				if (_albedoDynamicTextureRes == null)
				{
					_albedoDynamicTextureRes = (rRef<DynamicTexture>) CR2WTypeManager.Create("rRef:DynamicTexture", "albedoDynamicTextureRes", cr2w, this);
				}
				return _albedoDynamicTextureRes;
			}
			set
			{
				if (_albedoDynamicTextureRes == value)
				{
					return;
				}
				_albedoDynamicTextureRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("normalsDynamicTextureRes")] 
		public rRef<DynamicTexture> NormalsDynamicTextureRes
		{
			get
			{
				if (_normalsDynamicTextureRes == null)
				{
					_normalsDynamicTextureRes = (rRef<DynamicTexture>) CR2WTypeManager.Create("rRef:DynamicTexture", "normalsDynamicTextureRes", cr2w, this);
				}
				return _normalsDynamicTextureRes;
			}
			set
			{
				if (_normalsDynamicTextureRes == value)
				{
					return;
				}
				_normalsDynamicTextureRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("particlesDynamicTextureRes")] 
		public rRef<DynamicTexture> ParticlesDynamicTextureRes
		{
			get
			{
				if (_particlesDynamicTextureRes == null)
				{
					_particlesDynamicTextureRes = (rRef<DynamicTexture>) CR2WTypeManager.Create("rRef:DynamicTexture", "particlesDynamicTextureRes", cr2w, this);
				}
				return _particlesDynamicTextureRes;
			}
			set
			{
				if (_particlesDynamicTextureRes == value)
				{
					return;
				}
				_particlesDynamicTextureRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("resolutionWidth")] 
		public CUInt32 ResolutionWidth
		{
			get
			{
				if (_resolutionWidth == null)
				{
					_resolutionWidth = (CUInt32) CR2WTypeManager.Create("Uint32", "resolutionWidth", cr2w, this);
				}
				return _resolutionWidth;
			}
			set
			{
				if (_resolutionWidth == value)
				{
					return;
				}
				_resolutionWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("resolutionHeight")] 
		public CUInt32 ResolutionHeight
		{
			get
			{
				if (_resolutionHeight == null)
				{
					_resolutionHeight = (CUInt32) CR2WTypeManager.Create("Uint32", "resolutionHeight", cr2w, this);
				}
				return _resolutionHeight;
			}
			set
			{
				if (_resolutionHeight == value)
				{
					return;
				}
				_resolutionHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("aspectRatio")] 
		public CFloat AspectRatio
		{
			get
			{
				if (_aspectRatio == null)
				{
					_aspectRatio = (CFloat) CR2WTypeManager.Create("Float", "aspectRatio", cr2w, this);
				}
				return _aspectRatio;
			}
			set
			{
				if (_aspectRatio == value)
				{
					return;
				}
				_aspectRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("env")] 
		public rRef<worldEnvironmentAreaParameters> Env
		{
			get
			{
				if (_env == null)
				{
					_env = (rRef<worldEnvironmentAreaParameters>) CR2WTypeManager.Create("rRef:worldEnvironmentAreaParameters", "env", cr2w, this);
				}
				return _env;
			}
			set
			{
				if (_env == value)
				{
					return;
				}
				_env = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get
			{
				if (_params == null)
				{
					_params = (WorldRenderAreaSettings) CR2WTypeManager.Create("WorldRenderAreaSettings", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("renderingMode")] 
		public CEnum<entRenderToTextureMode> RenderingMode
		{
			get
			{
				if (_renderingMode == null)
				{
					_renderingMode = (CEnum<entRenderToTextureMode>) CR2WTypeManager.Create("entRenderToTextureMode", "renderingMode", cr2w, this);
				}
				return _renderingMode;
			}
			set
			{
				if (_renderingMode == value)
				{
					return;
				}
				_renderingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("depthCutDistance")] 
		public CFloat DepthCutDistance
		{
			get
			{
				if (_depthCutDistance == null)
				{
					_depthCutDistance = (CFloat) CR2WTypeManager.Create("Float", "depthCutDistance", cr2w, this);
				}
				return _depthCutDistance;
			}
			set
			{
				if (_depthCutDistance == value)
				{
					return;
				}
				_depthCutDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get
			{
				if (_backgroundColor == null)
				{
					_backgroundColor = (CColor) CR2WTypeManager.Create("Color", "backgroundColor", cr2w, this);
				}
				return _backgroundColor;
			}
			set
			{
				if (_backgroundColor == value)
				{
					return;
				}
				_backgroundColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("overrideBackgroundColor")] 
		public CBool OverrideBackgroundColor
		{
			get
			{
				if (_overrideBackgroundColor == null)
				{
					_overrideBackgroundColor = (CBool) CR2WTypeManager.Create("Bool", "overrideBackgroundColor", cr2w, this);
				}
				return _overrideBackgroundColor;
			}
			set
			{
				if (_overrideBackgroundColor == value)
				{
					return;
				}
				_overrideBackgroundColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get
			{
				if (_renderSceneLayer == null)
				{
					_renderSceneLayer = (CEnum<RenderSceneLayer>) CR2WTypeManager.Create("RenderSceneLayer", "renderSceneLayer", cr2w, this);
				}
				return _renderSceneLayer;
			}
			set
			{
				if (_renderSceneLayer == value)
				{
					return;
				}
				_renderSceneLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("features")] 
		public entRenderToTextureFeatures Features
		{
			get
			{
				if (_features == null)
				{
					_features = (entRenderToTextureFeatures) CR2WTypeManager.Create("entRenderToTextureFeatures", "features", cr2w, this);
				}
				return _features;
			}
			set
			{
				if (_features == value)
				{
					return;
				}
				_features = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get
			{
				if (_streamingDistance == null)
				{
					_streamingDistance = (CFloat) CR2WTypeManager.Create("Float", "streamingDistance", cr2w, this);
				}
				return _streamingDistance;
			}
			set
			{
				if (_streamingDistance == value)
				{
					return;
				}
				_streamingDistance = value;
				PropertySet(this);
			}
		}

		public entRenderToTextureCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
