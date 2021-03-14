using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldReflectionProbeNode : worldNode
	{
		private raRef<CReflectionProbeDataResource> _probeDataRef;
		private CUInt8 _priority;
		private CBool _globalProbe;
		private CBool _boxProjection;
		private CEnum<envUtilsNeighborMode> _neighborMode;
		private Vector3 _edgeScale;
		private CEnum<rendLightChannel> _lightChannels;
		private CFloat _emissiveScale;
		private CFloat _reflectionDimming;
		private HDRColor _simpleFogColor;
		private CFloat _simpleFogDensity;
		private CFloat _skyScale;
		private CBool _allInShadow;
		private CBool _hideSkyColor;
		private CBool _volFogAmbient;
		private CInt8 _brightnessEVClamp;
		private CEnum<envUtilsReflectionProbeAmbientContributionMode> _ambientMode;
		private Vector3 _captureOffset;
		private CFloat _nearClipDistance;
		private CFloat _farClipDistance;
		private CEnum<rendLightChannel> _volumeChannels;
		private CUInt8 _blendRange;
		private CFloat _streamingDistance;
		private CFloat _streamingHeight;
		private CBool _subScene;
		private CBool _noFadeBlend;

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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
		[RED("reflectionDimming")] 
		public CFloat ReflectionDimming
		{
			get
			{
				if (_reflectionDimming == null)
				{
					_reflectionDimming = (CFloat) CR2WTypeManager.Create("Float", "reflectionDimming", cr2w, this);
				}
				return _reflectionDimming;
			}
			set
			{
				if (_reflectionDimming == value)
				{
					return;
				}
				_reflectionDimming = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("simpleFogColor")] 
		public HDRColor SimpleFogColor
		{
			get
			{
				if (_simpleFogColor == null)
				{
					_simpleFogColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "simpleFogColor", cr2w, this);
				}
				return _simpleFogColor;
			}
			set
			{
				if (_simpleFogColor == value)
				{
					return;
				}
				_simpleFogColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("simpleFogDensity")] 
		public CFloat SimpleFogDensity
		{
			get
			{
				if (_simpleFogDensity == null)
				{
					_simpleFogDensity = (CFloat) CR2WTypeManager.Create("Float", "simpleFogDensity", cr2w, this);
				}
				return _simpleFogDensity;
			}
			set
			{
				if (_simpleFogDensity == value)
				{
					return;
				}
				_simpleFogDensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("skyScale")] 
		public CFloat SkyScale
		{
			get
			{
				if (_skyScale == null)
				{
					_skyScale = (CFloat) CR2WTypeManager.Create("Float", "skyScale", cr2w, this);
				}
				return _skyScale;
			}
			set
			{
				if (_skyScale == value)
				{
					return;
				}
				_skyScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("volFogAmbient")] 
		public CBool VolFogAmbient
		{
			get
			{
				if (_volFogAmbient == null)
				{
					_volFogAmbient = (CBool) CR2WTypeManager.Create("Bool", "volFogAmbient", cr2w, this);
				}
				return _volFogAmbient;
			}
			set
			{
				if (_volFogAmbient == value)
				{
					return;
				}
				_volFogAmbient = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("brightnessEVClamp")] 
		public CInt8 BrightnessEVClamp
		{
			get
			{
				if (_brightnessEVClamp == null)
				{
					_brightnessEVClamp = (CInt8) CR2WTypeManager.Create("Int8", "brightnessEVClamp", cr2w, this);
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
		[RED("captureOffset")] 
		public Vector3 CaptureOffset
		{
			get
			{
				if (_captureOffset == null)
				{
					_captureOffset = (Vector3) CR2WTypeManager.Create("Vector3", "captureOffset", cr2w, this);
				}
				return _captureOffset;
			}
			set
			{
				if (_captureOffset == value)
				{
					return;
				}
				_captureOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("nearClipDistance")] 
		public CFloat NearClipDistance
		{
			get
			{
				if (_nearClipDistance == null)
				{
					_nearClipDistance = (CFloat) CR2WTypeManager.Create("Float", "nearClipDistance", cr2w, this);
				}
				return _nearClipDistance;
			}
			set
			{
				if (_nearClipDistance == value)
				{
					return;
				}
				_nearClipDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("farClipDistance")] 
		public CFloat FarClipDistance
		{
			get
			{
				if (_farClipDistance == null)
				{
					_farClipDistance = (CFloat) CR2WTypeManager.Create("Float", "farClipDistance", cr2w, this);
				}
				return _farClipDistance;
			}
			set
			{
				if (_farClipDistance == value)
				{
					return;
				}
				_farClipDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
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

		[Ordinal(28)] 
		[RED("subScene")] 
		public CBool SubScene
		{
			get
			{
				if (_subScene == null)
				{
					_subScene = (CBool) CR2WTypeManager.Create("Bool", "subScene", cr2w, this);
				}
				return _subScene;
			}
			set
			{
				if (_subScene == value)
				{
					return;
				}
				_subScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("noFadeBlend")] 
		public CBool NoFadeBlend
		{
			get
			{
				if (_noFadeBlend == null)
				{
					_noFadeBlend = (CBool) CR2WTypeManager.Create("Bool", "noFadeBlend", cr2w, this);
				}
				return _noFadeBlend;
			}
			set
			{
				if (_noFadeBlend == value)
				{
					return;
				}
				_noFadeBlend = value;
				PropertySet(this);
			}
		}

		public worldReflectionProbeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
