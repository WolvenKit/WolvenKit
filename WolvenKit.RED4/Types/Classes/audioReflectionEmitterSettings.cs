using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioReflectionEmitterSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("reflectionEvent")] 
		public CName ReflectionEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("fadeout")] 
		public CFloat Fadeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("reflectionDeltaThreshold")] 
		public CFloat ReflectionDeltaThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxConcurrentReflections")] 
		public CUInt32 MaxConcurrentReflections
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("broadcastChannel")] 
		public CUInt32 BroadcastChannel
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("listenerRelativePosition")] 
		public CBool ListenerRelativePosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("upReflectionEnabled")] 
		public CBool UpReflectionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("shortReflectionIndoors")] 
		public CBool ShortReflectionIndoors
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("reflectionVariant")] 
		public CEnum<audioReflectionVariant> ReflectionVariant
		{
			get => GetPropertyValue<CEnum<audioReflectionVariant>>();
			set => SetPropertyValue<CEnum<audioReflectionVariant>>(value);
		}

		[Ordinal(10)] 
		[RED("backReflectionCutoffSpread")] 
		public CFloat BackReflectionCutoffSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("backReflectionCutoffStrength")] 
		public CFloat BackReflectionCutoffStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("backReflectionCutoffSoftness")] 
		public CFloat BackReflectionCutoffSoftness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("farReflectionDistance")] 
		public CFloat FarReflectionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("nearReflectionDistance")] 
		public CFloat NearReflectionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("minimumFaceAlignement")] 
		public CFloat MinimumFaceAlignement
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("fixedRaycastPitch")] 
		public CFloat FixedRaycastPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioReflectionEmitterSettings()
		{
			ReflectionDeltaThreshold = 1.000000F;
			MaxConcurrentReflections = 2;
			UpReflectionEnabled = true;
			ShortReflectionIndoors = true;
			ReflectionVariant = Enums.audioReflectionVariant.FindingMaximumFaceAlignemnt;
			BackReflectionCutoffStrength = 1.000000F;
			BackReflectionCutoffSoftness = 1.000000F;
			FarReflectionDistance = 80.000000F;
			NearReflectionDistance = 10.000000F;
			MinimumFaceAlignement = 0.500000F;
			FixedRaycastPitch = 15.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
