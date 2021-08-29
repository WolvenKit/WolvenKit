using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldReflectionProbeNode : worldNode
	{
		private CResourceAsyncReference<CReflectionProbeDataResource> _probeDataRef;
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
		public CResourceAsyncReference<CReflectionProbeDataResource> ProbeDataRef
		{
			get => GetProperty(ref _probeDataRef);
			set => SetProperty(ref _probeDataRef, value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(6)] 
		[RED("globalProbe")] 
		public CBool GlobalProbe
		{
			get => GetProperty(ref _globalProbe);
			set => SetProperty(ref _globalProbe, value);
		}

		[Ordinal(7)] 
		[RED("boxProjection")] 
		public CBool BoxProjection
		{
			get => GetProperty(ref _boxProjection);
			set => SetProperty(ref _boxProjection, value);
		}

		[Ordinal(8)] 
		[RED("neighborMode")] 
		public CEnum<envUtilsNeighborMode> NeighborMode
		{
			get => GetProperty(ref _neighborMode);
			set => SetProperty(ref _neighborMode, value);
		}

		[Ordinal(9)] 
		[RED("edgeScale")] 
		public Vector3 EdgeScale
		{
			get => GetProperty(ref _edgeScale);
			set => SetProperty(ref _edgeScale, value);
		}

		[Ordinal(10)] 
		[RED("lightChannels")] 
		public CEnum<rendLightChannel> LightChannels
		{
			get => GetProperty(ref _lightChannels);
			set => SetProperty(ref _lightChannels, value);
		}

		[Ordinal(11)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get => GetProperty(ref _emissiveScale);
			set => SetProperty(ref _emissiveScale, value);
		}

		[Ordinal(12)] 
		[RED("reflectionDimming")] 
		public CFloat ReflectionDimming
		{
			get => GetProperty(ref _reflectionDimming);
			set => SetProperty(ref _reflectionDimming, value);
		}

		[Ordinal(13)] 
		[RED("simpleFogColor")] 
		public HDRColor SimpleFogColor
		{
			get => GetProperty(ref _simpleFogColor);
			set => SetProperty(ref _simpleFogColor, value);
		}

		[Ordinal(14)] 
		[RED("simpleFogDensity")] 
		public CFloat SimpleFogDensity
		{
			get => GetProperty(ref _simpleFogDensity);
			set => SetProperty(ref _simpleFogDensity, value);
		}

		[Ordinal(15)] 
		[RED("skyScale")] 
		public CFloat SkyScale
		{
			get => GetProperty(ref _skyScale);
			set => SetProperty(ref _skyScale, value);
		}

		[Ordinal(16)] 
		[RED("allInShadow")] 
		public CBool AllInShadow
		{
			get => GetProperty(ref _allInShadow);
			set => SetProperty(ref _allInShadow, value);
		}

		[Ordinal(17)] 
		[RED("hideSkyColor")] 
		public CBool HideSkyColor
		{
			get => GetProperty(ref _hideSkyColor);
			set => SetProperty(ref _hideSkyColor, value);
		}

		[Ordinal(18)] 
		[RED("volFogAmbient")] 
		public CBool VolFogAmbient
		{
			get => GetProperty(ref _volFogAmbient);
			set => SetProperty(ref _volFogAmbient, value);
		}

		[Ordinal(19)] 
		[RED("brightnessEVClamp")] 
		public CInt8 BrightnessEVClamp
		{
			get => GetProperty(ref _brightnessEVClamp);
			set => SetProperty(ref _brightnessEVClamp, value);
		}

		[Ordinal(20)] 
		[RED("ambientMode")] 
		public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode
		{
			get => GetProperty(ref _ambientMode);
			set => SetProperty(ref _ambientMode, value);
		}

		[Ordinal(21)] 
		[RED("captureOffset")] 
		public Vector3 CaptureOffset
		{
			get => GetProperty(ref _captureOffset);
			set => SetProperty(ref _captureOffset, value);
		}

		[Ordinal(22)] 
		[RED("nearClipDistance")] 
		public CFloat NearClipDistance
		{
			get => GetProperty(ref _nearClipDistance);
			set => SetProperty(ref _nearClipDistance, value);
		}

		[Ordinal(23)] 
		[RED("farClipDistance")] 
		public CFloat FarClipDistance
		{
			get => GetProperty(ref _farClipDistance);
			set => SetProperty(ref _farClipDistance, value);
		}

		[Ordinal(24)] 
		[RED("volumeChannels")] 
		public CEnum<rendLightChannel> VolumeChannels
		{
			get => GetProperty(ref _volumeChannels);
			set => SetProperty(ref _volumeChannels, value);
		}

		[Ordinal(25)] 
		[RED("blendRange")] 
		public CUInt8 BlendRange
		{
			get => GetProperty(ref _blendRange);
			set => SetProperty(ref _blendRange, value);
		}

		[Ordinal(26)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(27)] 
		[RED("streamingHeight")] 
		public CFloat StreamingHeight
		{
			get => GetProperty(ref _streamingHeight);
			set => SetProperty(ref _streamingHeight, value);
		}

		[Ordinal(28)] 
		[RED("subScene")] 
		public CBool SubScene
		{
			get => GetProperty(ref _subScene);
			set => SetProperty(ref _subScene, value);
		}

		[Ordinal(29)] 
		[RED("noFadeBlend")] 
		public CBool NoFadeBlend
		{
			get => GetProperty(ref _noFadeBlend);
			set => SetProperty(ref _noFadeBlend, value);
		}
	}
}
