using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDynamicReverbSettings : audioAudioMetadata
	{
		private CEnum<audioDynamicReverbType> _reverbType;
		private audioReverbCrossoverParams _crossover1;
		private audioReverbCrossoverParams _crossover2;
		private CFloat _maxDistance;
		private CName _smallReverb;
		private CFloat _smallReverbMaxDistance;
		private CFloat _smallReverbFadeOutThreshold;
		private CName _mediumReverb;
		private CName _largeReverb;
		private CName _vehicleReverb;
		private CBool _overrideWeaponTail;
		private CName _sourceBasedReverbSet;
		private CEnum<audioWeaponTailEnvironment> _weaponTailType;
		private CEnum<audioEchoPositionType> _echoPositionType;
		private CEnum<audioEchoPositionType> _reportPositionType;

		[Ordinal(1)] 
		[RED("reverbType")] 
		public CEnum<audioDynamicReverbType> ReverbType
		{
			get => GetProperty(ref _reverbType);
			set => SetProperty(ref _reverbType, value);
		}

		[Ordinal(2)] 
		[RED("crossover1")] 
		public audioReverbCrossoverParams Crossover1
		{
			get => GetProperty(ref _crossover1);
			set => SetProperty(ref _crossover1, value);
		}

		[Ordinal(3)] 
		[RED("crossover2")] 
		public audioReverbCrossoverParams Crossover2
		{
			get => GetProperty(ref _crossover2);
			set => SetProperty(ref _crossover2, value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(5)] 
		[RED("smallReverb")] 
		public CName SmallReverb
		{
			get => GetProperty(ref _smallReverb);
			set => SetProperty(ref _smallReverb, value);
		}

		[Ordinal(6)] 
		[RED("smallReverbMaxDistance")] 
		public CFloat SmallReverbMaxDistance
		{
			get => GetProperty(ref _smallReverbMaxDistance);
			set => SetProperty(ref _smallReverbMaxDistance, value);
		}

		[Ordinal(7)] 
		[RED("smallReverbFadeOutThreshold")] 
		public CFloat SmallReverbFadeOutThreshold
		{
			get => GetProperty(ref _smallReverbFadeOutThreshold);
			set => SetProperty(ref _smallReverbFadeOutThreshold, value);
		}

		[Ordinal(8)] 
		[RED("mediumReverb")] 
		public CName MediumReverb
		{
			get => GetProperty(ref _mediumReverb);
			set => SetProperty(ref _mediumReverb, value);
		}

		[Ordinal(9)] 
		[RED("largeReverb")] 
		public CName LargeReverb
		{
			get => GetProperty(ref _largeReverb);
			set => SetProperty(ref _largeReverb, value);
		}

		[Ordinal(10)] 
		[RED("vehicleReverb")] 
		public CName VehicleReverb
		{
			get => GetProperty(ref _vehicleReverb);
			set => SetProperty(ref _vehicleReverb, value);
		}

		[Ordinal(11)] 
		[RED("overrideWeaponTail")] 
		public CBool OverrideWeaponTail
		{
			get => GetProperty(ref _overrideWeaponTail);
			set => SetProperty(ref _overrideWeaponTail, value);
		}

		[Ordinal(12)] 
		[RED("sourceBasedReverbSet")] 
		public CName SourceBasedReverbSet
		{
			get => GetProperty(ref _sourceBasedReverbSet);
			set => SetProperty(ref _sourceBasedReverbSet, value);
		}

		[Ordinal(13)] 
		[RED("weaponTailType")] 
		public CEnum<audioWeaponTailEnvironment> WeaponTailType
		{
			get => GetProperty(ref _weaponTailType);
			set => SetProperty(ref _weaponTailType, value);
		}

		[Ordinal(14)] 
		[RED("echoPositionType")] 
		public CEnum<audioEchoPositionType> EchoPositionType
		{
			get => GetProperty(ref _echoPositionType);
			set => SetProperty(ref _echoPositionType, value);
		}

		[Ordinal(15)] 
		[RED("reportPositionType")] 
		public CEnum<audioEchoPositionType> ReportPositionType
		{
			get => GetProperty(ref _reportPositionType);
			set => SetProperty(ref _reportPositionType, value);
		}

		public audioDynamicReverbSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
