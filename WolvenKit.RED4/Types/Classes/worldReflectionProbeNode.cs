using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldReflectionProbeNode : worldNode
	{
		[Ordinal(2)] 
		[RED("probeDataRef")] 
		public CResourceAsyncReference<CReflectionProbeDataResource> ProbeDataRef
		{
			get => GetPropertyValue<CResourceAsyncReference<CReflectionProbeDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CReflectionProbeDataResource>>(value);
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("globalProbe")] 
		public CBool GlobalProbe
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("boxProjection")] 
		public CBool BoxProjection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("neighborMode")] 
		public CEnum<envUtilsNeighborMode> NeighborMode
		{
			get => GetPropertyValue<CEnum<envUtilsNeighborMode>>();
			set => SetPropertyValue<CEnum<envUtilsNeighborMode>>(value);
		}

		[Ordinal(7)] 
		[RED("edgeScale")] 
		public Vector3 EdgeScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("lightChannels")] 
		public CBitField<rendLightChannel> LightChannels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(9)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("reflectionDimming")] 
		public CFloat ReflectionDimming
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("simpleFogColor")] 
		public HDRColor SimpleFogColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(12)] 
		[RED("simpleFogDensity")] 
		public CFloat SimpleFogDensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("skyScale")] 
		public CFloat SkyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("allInShadow")] 
		public CBool AllInShadow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("hideSkyColor")] 
		public CBool HideSkyColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("volFogAmbient")] 
		public CBool VolFogAmbient
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("brightnessEVClamp")] 
		public CInt8 BrightnessEVClamp
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(18)] 
		[RED("ambientMode")] 
		public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode
		{
			get => GetPropertyValue<CEnum<envUtilsReflectionProbeAmbientContributionMode>>();
			set => SetPropertyValue<CEnum<envUtilsReflectionProbeAmbientContributionMode>>(value);
		}

		[Ordinal(19)] 
		[RED("captureOffset")] 
		public Vector3 CaptureOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(20)] 
		[RED("nearClipDistance")] 
		public CFloat NearClipDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("farClipDistance")] 
		public CFloat FarClipDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("volumeChannels")] 
		public CBitField<rendLightChannel> VolumeChannels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(23)] 
		[RED("blendRange")] 
		public CUInt8 BlendRange
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(24)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("streamingHeight")] 
		public CFloat StreamingHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("subScene")] 
		public CBool SubScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("noFadeBlend")] 
		public CBool NoFadeBlend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldReflectionProbeNode()
		{
			Priority = 2;
			BoxProjection = true;
			NeighborMode = Enums.envUtilsNeighborMode.eONLY_SELF;
			EdgeScale = new Vector3 { X = 0.980000F, Y = 0.980000F, Z = 0.980000F };
			EmissiveScale = 1.000000F;
			ReflectionDimming = 1.000000F;
			SimpleFogColor = new HDRColor { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			SkyScale = 1.000000F;
			VolFogAmbient = true;
			BrightnessEVClamp = 8;
			CaptureOffset = new Vector3();
			NearClipDistance = 0.010000F;
			FarClipDistance = 4000.000000F;
			BlendRange = 20;
			StreamingDistance = 64.000000F;
			StreamingHeight = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
