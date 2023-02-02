using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDynamicReverbSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("reverbType")] 
		public CEnum<audioDynamicReverbType> ReverbType
		{
			get => GetPropertyValue<CEnum<audioDynamicReverbType>>();
			set => SetPropertyValue<CEnum<audioDynamicReverbType>>(value);
		}

		[Ordinal(2)] 
		[RED("crossover1")] 
		public audioReverbCrossoverParams Crossover1
		{
			get => GetPropertyValue<audioReverbCrossoverParams>();
			set => SetPropertyValue<audioReverbCrossoverParams>(value);
		}

		[Ordinal(3)] 
		[RED("crossover2")] 
		public audioReverbCrossoverParams Crossover2
		{
			get => GetPropertyValue<audioReverbCrossoverParams>();
			set => SetPropertyValue<audioReverbCrossoverParams>(value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("smallReverb")] 
		public CName SmallReverb
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("smallReverbMaxDistance")] 
		public CFloat SmallReverbMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("smallReverbFadeOutThreshold")] 
		public CFloat SmallReverbFadeOutThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("mediumReverb")] 
		public CName MediumReverb
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("largeReverb")] 
		public CName LargeReverb
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleReverb")] 
		public CName VehicleReverb
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("overrideWeaponTail")] 
		public CBool OverrideWeaponTail
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("sourceBasedReverbSet")] 
		public CName SourceBasedReverbSet
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("weaponTailType")] 
		public CEnum<audioWeaponTailEnvironment> WeaponTailType
		{
			get => GetPropertyValue<CEnum<audioWeaponTailEnvironment>>();
			set => SetPropertyValue<CEnum<audioWeaponTailEnvironment>>(value);
		}

		[Ordinal(14)] 
		[RED("echoPositionType")] 
		public CEnum<audioEchoPositionType> EchoPositionType
		{
			get => GetPropertyValue<CEnum<audioEchoPositionType>>();
			set => SetPropertyValue<CEnum<audioEchoPositionType>>(value);
		}

		[Ordinal(15)] 
		[RED("reportPositionType")] 
		public CEnum<audioEchoPositionType> ReportPositionType
		{
			get => GetPropertyValue<CEnum<audioEchoPositionType>>();
			set => SetPropertyValue<CEnum<audioEchoPositionType>>(value);
		}

		public audioDynamicReverbSettings()
		{
			Crossover1 = new();
			Crossover2 = new();
			SmallReverbMaxDistance = 20.000000F;
			SmallReverbFadeOutThreshold = 15.000000F;
			WeaponTailType = Enums.audioWeaponTailEnvironment.ExteriorUrbanNarrow;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
