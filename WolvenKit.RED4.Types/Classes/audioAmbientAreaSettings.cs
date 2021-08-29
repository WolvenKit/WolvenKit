using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAmbientAreaSettings : audioAudioMetadata
	{
		private CName _metadataParent;
		private CName _emitterDecorator;
		private CInt32 _priority;
		private CArray<audioAudEventStruct> _eventsOnEnter;
		private CArray<audioAudEventStruct> _eventsOnExit;
		private CArray<audioAudEventStruct> _eventsOnActive;
		private CArray<audioSoundBankStruct> _soundBanks;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _parameters;
		private CName _reverb;
		private CFloat _reverbTransitionTime;
		private CName _voReverb;
		private CName _footstepMaterialOverride;
		private CBool _isMusic;
		private audioAmbientAreaGroupingSettings _groupingSettings;
		private audioQuadEmitterSettings _quadSettings;
		private CFloat _outerDistance;
		private CFloat _verticalOuterDistance;
		private CFloat _insideSourceDistance;
		private CName _eventOverrides;
		private CBool _outdoornessOverride;
		private CFloat _outdoorness;
		private CBool _mergeRoomsWithinArea;
		private CName _mixingContext;
		private CArray<audioAmbientPaletteEntry> _ambientPaletteEntries;

		[Ordinal(1)] 
		[RED("MetadataParent")] 
		public CName MetadataParent
		{
			get => GetProperty(ref _metadataParent);
			set => SetProperty(ref _metadataParent, value);
		}

		[Ordinal(2)] 
		[RED("EmitterDecorator")] 
		public CName EmitterDecorator
		{
			get => GetProperty(ref _emitterDecorator);
			set => SetProperty(ref _emitterDecorator, value);
		}

		[Ordinal(3)] 
		[RED("Priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(4)] 
		[RED("EventsOnEnter")] 
		public CArray<audioAudEventStruct> EventsOnEnter
		{
			get => GetProperty(ref _eventsOnEnter);
			set => SetProperty(ref _eventsOnEnter, value);
		}

		[Ordinal(5)] 
		[RED("EventsOnExit")] 
		public CArray<audioAudEventStruct> EventsOnExit
		{
			get => GetProperty(ref _eventsOnExit);
			set => SetProperty(ref _eventsOnExit, value);
		}

		[Ordinal(6)] 
		[RED("EventsOnActive")] 
		public CArray<audioAudEventStruct> EventsOnActive
		{
			get => GetProperty(ref _eventsOnActive);
			set => SetProperty(ref _eventsOnActive, value);
		}

		[Ordinal(7)] 
		[RED("SoundBanks")] 
		public CArray<audioSoundBankStruct> SoundBanks
		{
			get => GetProperty(ref _soundBanks);
			set => SetProperty(ref _soundBanks, value);
		}

		[Ordinal(8)] 
		[RED("Switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetProperty(ref _switches);
			set => SetProperty(ref _switches, value);
		}

		[Ordinal(9)] 
		[RED("Parameters")] 
		public CArray<audioAudParameter> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}

		[Ordinal(10)] 
		[RED("Reverb")] 
		public CName Reverb
		{
			get => GetProperty(ref _reverb);
			set => SetProperty(ref _reverb, value);
		}

		[Ordinal(11)] 
		[RED("reverbTransitionTime")] 
		public CFloat ReverbTransitionTime
		{
			get => GetProperty(ref _reverbTransitionTime);
			set => SetProperty(ref _reverbTransitionTime, value);
		}

		[Ordinal(12)] 
		[RED("VoReverb")] 
		public CName VoReverb
		{
			get => GetProperty(ref _voReverb);
			set => SetProperty(ref _voReverb, value);
		}

		[Ordinal(13)] 
		[RED("FootstepMaterialOverride")] 
		public CName FootstepMaterialOverride
		{
			get => GetProperty(ref _footstepMaterialOverride);
			set => SetProperty(ref _footstepMaterialOverride, value);
		}

		[Ordinal(14)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetProperty(ref _isMusic);
			set => SetProperty(ref _isMusic, value);
		}

		[Ordinal(15)] 
		[RED("groupingSettings")] 
		public audioAmbientAreaGroupingSettings GroupingSettings
		{
			get => GetProperty(ref _groupingSettings);
			set => SetProperty(ref _groupingSettings, value);
		}

		[Ordinal(16)] 
		[RED("quadSettings")] 
		public audioQuadEmitterSettings QuadSettings
		{
			get => GetProperty(ref _quadSettings);
			set => SetProperty(ref _quadSettings, value);
		}

		[Ordinal(17)] 
		[RED("outerDistance")] 
		public CFloat OuterDistance
		{
			get => GetProperty(ref _outerDistance);
			set => SetProperty(ref _outerDistance, value);
		}

		[Ordinal(18)] 
		[RED("verticalOuterDistance")] 
		public CFloat VerticalOuterDistance
		{
			get => GetProperty(ref _verticalOuterDistance);
			set => SetProperty(ref _verticalOuterDistance, value);
		}

		[Ordinal(19)] 
		[RED("insideSourceDistance")] 
		public CFloat InsideSourceDistance
		{
			get => GetProperty(ref _insideSourceDistance);
			set => SetProperty(ref _insideSourceDistance, value);
		}

		[Ordinal(20)] 
		[RED("eventOverrides")] 
		public CName EventOverrides
		{
			get => GetProperty(ref _eventOverrides);
			set => SetProperty(ref _eventOverrides, value);
		}

		[Ordinal(21)] 
		[RED("outdoornessOverride")] 
		public CBool OutdoornessOverride
		{
			get => GetProperty(ref _outdoornessOverride);
			set => SetProperty(ref _outdoornessOverride, value);
		}

		[Ordinal(22)] 
		[RED("outdoorness")] 
		public CFloat Outdoorness
		{
			get => GetProperty(ref _outdoorness);
			set => SetProperty(ref _outdoorness, value);
		}

		[Ordinal(23)] 
		[RED("mergeRoomsWithinArea")] 
		public CBool MergeRoomsWithinArea
		{
			get => GetProperty(ref _mergeRoomsWithinArea);
			set => SetProperty(ref _mergeRoomsWithinArea, value);
		}

		[Ordinal(24)] 
		[RED("mixingContext")] 
		public CName MixingContext
		{
			get => GetProperty(ref _mixingContext);
			set => SetProperty(ref _mixingContext, value);
		}

		[Ordinal(25)] 
		[RED("ambientPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> AmbientPaletteEntries
		{
			get => GetProperty(ref _ambientPaletteEntries);
			set => SetProperty(ref _ambientPaletteEntries, value);
		}
	}
}
