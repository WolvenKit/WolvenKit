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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		public gamePhotoModeBackgroundCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
