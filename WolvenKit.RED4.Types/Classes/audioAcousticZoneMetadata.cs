using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAcousticZoneMetadata : audioAudioMetadata
	{
		private CInt32 _priority;
		private CFloat _bleadingDistance;
		private CArray<CName> _eventsOnEnter;
		private CArray<CName> _eventsOnExit;
		private CArray<CName> _eventsOnActive;
		private CArray<CName> _soundBanks;
		private CArray<audioAcousticZoneParameterMapItem> _parameters;
		private CName _reverbSettings;
		private CName _voReverbSettings;
		private CName _footstepMaterialOverride;

		[Ordinal(1)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(2)] 
		[RED("bleadingDistance")] 
		public CFloat BleadingDistance
		{
			get => GetProperty(ref _bleadingDistance);
			set => SetProperty(ref _bleadingDistance, value);
		}

		[Ordinal(3)] 
		[RED("eventsOnEnter")] 
		public CArray<CName> EventsOnEnter
		{
			get => GetProperty(ref _eventsOnEnter);
			set => SetProperty(ref _eventsOnEnter, value);
		}

		[Ordinal(4)] 
		[RED("eventsOnExit")] 
		public CArray<CName> EventsOnExit
		{
			get => GetProperty(ref _eventsOnExit);
			set => SetProperty(ref _eventsOnExit, value);
		}

		[Ordinal(5)] 
		[RED("eventsOnActive")] 
		public CArray<CName> EventsOnActive
		{
			get => GetProperty(ref _eventsOnActive);
			set => SetProperty(ref _eventsOnActive, value);
		}

		[Ordinal(6)] 
		[RED("soundBanks")] 
		public CArray<CName> SoundBanks
		{
			get => GetProperty(ref _soundBanks);
			set => SetProperty(ref _soundBanks, value);
		}

		[Ordinal(7)] 
		[RED("parameters")] 
		public CArray<audioAcousticZoneParameterMapItem> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}

		[Ordinal(8)] 
		[RED("reverbSettings")] 
		public CName ReverbSettings
		{
			get => GetProperty(ref _reverbSettings);
			set => SetProperty(ref _reverbSettings, value);
		}

		[Ordinal(9)] 
		[RED("voReverbSettings")] 
		public CName VoReverbSettings
		{
			get => GetProperty(ref _voReverbSettings);
			set => SetProperty(ref _voReverbSettings, value);
		}

		[Ordinal(10)] 
		[RED("footstepMaterialOverride")] 
		public CName FootstepMaterialOverride
		{
			get => GetProperty(ref _footstepMaterialOverride);
			set => SetProperty(ref _footstepMaterialOverride, value);
		}

		public audioAcousticZoneMetadata()
		{
			_bleadingDistance = 10.000000F;
		}
	}
}
