using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEnvProbeComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("size")] 
		public Vector3 Size
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(10)] 
		[RED("edgeScale")] 
		public Vector3 EdgeScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(11)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("globalProbe")] 
		public CBool GlobalProbe
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("boxProjection")] 
		public CBool BoxProjection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("allInShadow")] 
		public CBool AllInShadow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("streamingHeight")] 
		public CFloat StreamingHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("blendRange")] 
		public CUInt8 BlendRange
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(18)] 
		[RED("neighborMode")] 
		public CEnum<envUtilsNeighborMode> NeighborMode
		{
			get => GetPropertyValue<CEnum<envUtilsNeighborMode>>();
			set => SetPropertyValue<CEnum<envUtilsNeighborMode>>(value);
		}

		[Ordinal(19)] 
		[RED("hideSkyColor")] 
		public CBool HideSkyColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("ambientMode")] 
		public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode
		{
			get => GetPropertyValue<CEnum<envUtilsReflectionProbeAmbientContributionMode>>();
			set => SetPropertyValue<CEnum<envUtilsReflectionProbeAmbientContributionMode>>(value);
		}

		[Ordinal(21)] 
		[RED("brightnessEVClamp")] 
		public CUInt8 BrightnessEVClamp
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(22)] 
		[RED("probeDataRef")] 
		public CResourceAsyncReference<CReflectionProbeDataResource> ProbeDataRef
		{
			get => GetPropertyValue<CResourceAsyncReference<CReflectionProbeDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CReflectionProbeDataResource>>(value);
		}

		[Ordinal(23)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(24)] 
		[RED("lightChannels")] 
		public CBitField<rendLightChannel> LightChannels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(25)] 
		[RED("volumeChannels")] 
		public CBitField<rendLightChannel> VolumeChannels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		public entEnvProbeComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			AutoHideDistance = -1.000000F;
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			IsEnabled = true;
			Size = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			EdgeScale = new() { X = 0.980000F, Y = 0.980000F, Z = 0.980000F };
			EmissiveScale = 1.000000F;
			BoxProjection = true;
			StreamingDistance = 16.000000F;
			StreamingHeight = -1.000000F;
			BlendRange = 20;
			NeighborMode = Enums.envUtilsNeighborMode.eONLY_SELF;
			BrightnessEVClamp = 8;
			Priority = 2;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
