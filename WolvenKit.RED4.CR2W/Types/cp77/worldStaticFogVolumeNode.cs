using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticFogVolumeNode : worldNode
	{
		private CUInt8 _priority;
		private CBool _absolute;
		private CBool _applyHeightFalloff;
		private CFloat _densityFalloff;
		private CFloat _blendFalloff;
		private CFloat _densityFactor;
		private CFloat _absorption;
		private CFloat _streamingDistance;
		private CFloat _ambientScale;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CColor _color;
		private CEnum<rendLightChannel> _lightChannels;

		[Ordinal(4)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt8) CR2WTypeManager.Create("Uint8", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("absolute")] 
		public CBool Absolute
		{
			get
			{
				if (_absolute == null)
				{
					_absolute = (CBool) CR2WTypeManager.Create("Bool", "absolute", cr2w, this);
				}
				return _absolute;
			}
			set
			{
				if (_absolute == value)
				{
					return;
				}
				_absolute = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("applyHeightFalloff")] 
		public CBool ApplyHeightFalloff
		{
			get
			{
				if (_applyHeightFalloff == null)
				{
					_applyHeightFalloff = (CBool) CR2WTypeManager.Create("Bool", "applyHeightFalloff", cr2w, this);
				}
				return _applyHeightFalloff;
			}
			set
			{
				if (_applyHeightFalloff == value)
				{
					return;
				}
				_applyHeightFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get
			{
				if (_densityFalloff == null)
				{
					_densityFalloff = (CFloat) CR2WTypeManager.Create("Float", "densityFalloff", cr2w, this);
				}
				return _densityFalloff;
			}
			set
			{
				if (_densityFalloff == value)
				{
					return;
				}
				_densityFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get
			{
				if (_blendFalloff == null)
				{
					_blendFalloff = (CFloat) CR2WTypeManager.Create("Float", "blendFalloff", cr2w, this);
				}
				return _blendFalloff;
			}
			set
			{
				if (_blendFalloff == value)
				{
					return;
				}
				_blendFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("densityFactor")] 
		public CFloat DensityFactor
		{
			get
			{
				if (_densityFactor == null)
				{
					_densityFactor = (CFloat) CR2WTypeManager.Create("Float", "densityFactor", cr2w, this);
				}
				return _densityFactor;
			}
			set
			{
				if (_densityFactor == value)
				{
					return;
				}
				_densityFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("absorption")] 
		public CFloat Absorption
		{
			get
			{
				if (_absorption == null)
				{
					_absorption = (CFloat) CR2WTypeManager.Create("Float", "absorption", cr2w, this);
				}
				return _absorption;
			}
			set
			{
				if (_absorption == value)
				{
					return;
				}
				_absorption = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("ambientScale")] 
		public CFloat AmbientScale
		{
			get
			{
				if (_ambientScale == null)
				{
					_ambientScale = (CFloat) CR2WTypeManager.Create("Float", "ambientScale", cr2w, this);
				}
				return _ambientScale;
			}
			set
			{
				if (_ambientScale == value)
				{
					return;
				}
				_ambientScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get
			{
				if (_envColorGroup == null)
				{
					_envColorGroup = (CEnum<EEnvColorGroup>) CR2WTypeManager.Create("EEnvColorGroup", "envColorGroup", cr2w, this);
				}
				return _envColorGroup;
			}
			set
			{
				if (_envColorGroup == value)
				{
					return;
				}
				_envColorGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lightChannels")] 
		public CEnum<rendLightChannel> LightChannels
		{
			get
			{
				if (_lightChannels == null)
				{
					_lightChannels = (CEnum<rendLightChannel>) CR2WTypeManager.Create("rendLightChannel", "lightChannels", cr2w, this);
				}
				return _lightChannels;
			}
			set
			{
				if (_lightChannels == value)
				{
					return;
				}
				_lightChannels = value;
				PropertySet(this);
			}
		}

		public worldStaticFogVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
