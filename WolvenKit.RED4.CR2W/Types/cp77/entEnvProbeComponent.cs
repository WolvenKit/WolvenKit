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
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(9)] 
		[RED("size")] 
		public Vector3 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(10)] 
		[RED("edgeScale")] 
		public Vector3 EdgeScale
		{
			get => GetProperty(ref _edgeScale);
			set => SetProperty(ref _edgeScale, value);
		}

		[Ordinal(11)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get => GetProperty(ref _emissiveScale);
			set => SetProperty(ref _emissiveScale, value);
		}

		[Ordinal(12)] 
		[RED("globalProbe")] 
		public CBool GlobalProbe
		{
			get => GetProperty(ref _globalProbe);
			set => SetProperty(ref _globalProbe, value);
		}

		[Ordinal(13)] 
		[RED("boxProjection")] 
		public CBool BoxProjection
		{
			get => GetProperty(ref _boxProjection);
			set => SetProperty(ref _boxProjection, value);
		}

		[Ordinal(14)] 
		[RED("allInShadow")] 
		public CBool AllInShadow
		{
			get => GetProperty(ref _allInShadow);
			set => SetProperty(ref _allInShadow, value);
		}

		[Ordinal(15)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(16)] 
		[RED("streamingHeight")] 
		public CFloat StreamingHeight
		{
			get => GetProperty(ref _streamingHeight);
			set => SetProperty(ref _streamingHeight, value);
		}

		[Ordinal(17)] 
		[RED("blendRange")] 
		public CUInt8 BlendRange
		{
			get => GetProperty(ref _blendRange);
			set => SetProperty(ref _blendRange, value);
		}

		[Ordinal(18)] 
		[RED("neighborMode")] 
		public CEnum<envUtilsNeighborMode> NeighborMode
		{
			get => GetProperty(ref _neighborMode);
			set => SetProperty(ref _neighborMode, value);
		}

		[Ordinal(19)] 
		[RED("hideSkyColor")] 
		public CBool HideSkyColor
		{
			get => GetProperty(ref _hideSkyColor);
			set => SetProperty(ref _hideSkyColor, value);
		}

		[Ordinal(20)] 
		[RED("ambientMode")] 
		public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode
		{
			get => GetProperty(ref _ambientMode);
			set => SetProperty(ref _ambientMode, value);
		}

		[Ordinal(21)] 
		[RED("brightnessEVClamp")] 
		public CUInt8 BrightnessEVClamp
		{
			get => GetProperty(ref _brightnessEVClamp);
			set => SetProperty(ref _brightnessEVClamp, value);
		}

		[Ordinal(22)] 
		[RED("probeDataRef")] 
		public raRef<CReflectionProbeDataResource> ProbeDataRef
		{
			get => GetProperty(ref _probeDataRef);
			set => SetProperty(ref _probeDataRef, value);
		}

		[Ordinal(23)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(24)] 
		[RED("lightChannels")] 
		public CEnum<rendLightChannel> LightChannels
		{
			get => GetProperty(ref _lightChannels);
			set => SetProperty(ref _lightChannels, value);
		}

		[Ordinal(25)] 
		[RED("volumeChannels")] 
		public CEnum<rendLightChannel> VolumeChannels
		{
			get => GetProperty(ref _volumeChannels);
			set => SetProperty(ref _volumeChannels, value);
		}

		public entEnvProbeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
