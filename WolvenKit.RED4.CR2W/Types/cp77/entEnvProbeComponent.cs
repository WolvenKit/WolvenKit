using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEnvProbeComponent : entIVisualComponent
	{
		private CBool _isEnabled;
		private Vector3 _size;
		private Vector3 _edgeScale;
		private CFloat _emissiveScale;
		private CBool _globalProbe;
		private CBool _boxProjection;
		private CBool _allInShadow;
		private CFloat _streamingDistance;
		private CFloat _streamingHeight;
		private CUInt8 _blendRange;
		private CEnum<envUtilsNeighborMode> _neighborMode;
		private CBool _hideSkyColor;
		private CEnum<envUtilsReflectionProbeAmbientContributionMode> _ambientMode;
		private CUInt8 _brightnessEVClamp;
		private raRef<CReflectionProbeDataResource> _probeDataRef;
		private CUInt8 _priority;
		private CEnum<rendLightChannel> _lightChannels;
		private CEnum<rendLightChannel> _volumeChannels;

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("size")] 
		public Vector3 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector3) CR2WTypeManager.Create("Vector3", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("edgeScale")] 
		public Vector3 EdgeScale
		{
			get
			{
				if (_edgeScale == null)
				{
					_edgeScale = (Vector3) CR2WTypeManager.Create("Vector3", "edgeScale", cr2w, this);
				}
				return _edgeScale;
			}
			set
			{
				if (_edgeScale == value)
				{
					return;
				}
				_edgeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get
			{
				if (_emissiveScale == null)
				{
					_emissiveScale = (CFloat) CR2WTypeManager.Create("Float", "emissiveScale", cr2w, this);
				}
				return _emissiveScale;
			}
			set
			{
				if (_emissiveScale == value)
				{
					return;
				}
				_emissiveScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("globalProbe")] 
		public CBool GlobalProbe
		{
			get
			{
				if (_globalProbe == null)
				{
					_globalProbe = (CBool) CR2WTypeManager.Create("Bool", "globalProbe", cr2w, this);
				}
				return _globalProbe;
			}
			set
			{
				if (_globalProbe == value)
				{
					return;
				}
				_globalProbe = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("boxProjection")] 
		public CBool BoxProjection
		{
			get
			{
				if (_boxProjection == null)
				{
					_boxProjection = (CBool) CR2WTypeManager.Create("Bool", "boxProjection", cr2w, this);
				}
				return _boxProjection;
			}
			set
			{
				if (_boxProjection == value)
				{
					return;
				}
				_boxProjection = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("allInShadow")] 
		public CBool AllInShadow
		{
			get
			{
				if (_allInShadow == null)
				{
					_allInShadow = (CBool) CR2WTypeManager.Create("Bool", "allInShadow", cr2w, this);
				}
				return _allInShadow;
			}
			set
			{
				if (_allInShadow == value)
				{
					return;
				}
				_allInShadow = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("streamingHeight")] 
		public CFloat StreamingHeight
		{
			get
			{
				if (_streamingHeight == null)
				{
					_streamingHeight = (CFloat) CR2WTypeManager.Create("Float", "streamingHeight", cr2w, this);
				}
				return _streamingHeight;
			}
			set
			{
				if (_streamingHeight == value)
				{
					return;
				}
				_streamingHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("blendRange")] 
		public CUInt8 BlendRange
		{
			get
			{
				if (_blendRange == null)
				{
					_blendRange = (CUInt8) CR2WTypeManager.Create("Uint8", "blendRange", cr2w, this);
				}
				return _blendRange;
			}
			set
			{
				if (_blendRange == value)
				{
					return;
				}
				_blendRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("neighborMode")] 
		public CEnum<envUtilsNeighborMode> NeighborMode
		{
			get
			{
				if (_neighborMode == null)
				{
					_neighborMode = (CEnum<envUtilsNeighborMode>) CR2WTypeManager.Create("envUtilsNeighborMode", "neighborMode", cr2w, this);
				}
				return _neighborMode;
			}
			set
			{
				if (_neighborMode == value)
				{
					return;
				}
				_neighborMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("hideSkyColor")] 
		public CBool HideSkyColor
		{
			get
			{
				if (_hideSkyColor == null)
				{
					_hideSkyColor = (CBool) CR2WTypeManager.Create("Bool", "hideSkyColor", cr2w, this);
				}
				return _hideSkyColor;
			}
			set
			{
				if (_hideSkyColor == value)
				{
					return;
				}
				_hideSkyColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ambientMode")] 
		public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode
		{
			get
			{
				if (_ambientMode == null)
				{
					_ambientMode = (CEnum<envUtilsReflectionProbeAmbientContributionMode>) CR2WTypeManager.Create("envUtilsReflectionProbeAmbientContributionMode", "ambientMode", cr2w, this);
				}
				return _ambientMode;
			}
			set
			{
				if (_ambientMode == value)
				{
					return;
				}
				_ambientMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("brightnessEVClamp")] 
		public CUInt8 BrightnessEVClamp
		{
			get
			{
				if (_brightnessEVClamp == null)
				{
					_brightnessEVClamp = (CUInt8) CR2WTypeManager.Create("Uint8", "brightnessEVClamp", cr2w, this);
				}
				return _brightnessEVClamp;
			}
			set
			{
				if (_brightnessEVClamp == value)
				{
					return;
				}
				_brightnessEVClamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("probeDataRef")] 
		public raRef<CReflectionProbeDataResource> ProbeDataRef
		{
			get
			{
				if (_probeDataRef == null)
				{
					_probeDataRef = (raRef<CReflectionProbeDataResource>) CR2WTypeManager.Create("raRef:CReflectionProbeDataResource", "probeDataRef", cr2w, this);
				}
				return _probeDataRef;
			}
			set
			{
				if (_probeDataRef == value)
				{
					return;
				}
				_probeDataRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("volumeChannels")] 
		public CEnum<rendLightChannel> VolumeChannels
		{
			get
			{
				if (_volumeChannels == null)
				{
					_volumeChannels = (CEnum<rendLightChannel>) CR2WTypeManager.Create("rendLightChannel", "volumeChannels", cr2w, this);
				}
				return _volumeChannels;
			}
			set
			{
				if (_volumeChannels == value)
				{
					return;
				}
				_volumeChannels = value;
				PropertySet(this);
			}
		}

		public entEnvProbeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
