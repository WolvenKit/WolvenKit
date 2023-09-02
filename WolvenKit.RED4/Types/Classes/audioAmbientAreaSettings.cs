using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientAreaSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("MetadataParent")] 
		public CName MetadataParent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("EmitterDecorator")] 
		public CName EmitterDecorator
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("Priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("EventsOnEnter")] 
		public CArray<audioAudEventStruct> EventsOnEnter
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(5)] 
		[RED("EventsOnExit")] 
		public CArray<audioAudEventStruct> EventsOnExit
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(6)] 
		[RED("EventsOnActive")] 
		public CArray<audioAudEventStruct> EventsOnActive
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(7)] 
		[RED("SoundBanks")] 
		public CArray<audioSoundBankStruct> SoundBanks
		{
			get => GetPropertyValue<CArray<audioSoundBankStruct>>();
			set => SetPropertyValue<CArray<audioSoundBankStruct>>(value);
		}

		[Ordinal(8)] 
		[RED("Switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetPropertyValue<CArray<audioAudSwitch>>();
			set => SetPropertyValue<CArray<audioAudSwitch>>(value);
		}

		[Ordinal(9)] 
		[RED("Parameters")] 
		public CArray<audioAudParameter> Parameters
		{
			get => GetPropertyValue<CArray<audioAudParameter>>();
			set => SetPropertyValue<CArray<audioAudParameter>>(value);
		}

		[Ordinal(10)] 
		[RED("Reverb")] 
		public CName Reverb
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("reverbTransitionTime")] 
		public CFloat ReverbTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("VoReverb")] 
		public CName VoReverb
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("FootstepMaterialOverride")] 
		public CName FootstepMaterialOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("groupingSettings")] 
		public audioAmbientAreaGroupingSettings GroupingSettings
		{
			get => GetPropertyValue<audioAmbientAreaGroupingSettings>();
			set => SetPropertyValue<audioAmbientAreaGroupingSettings>(value);
		}

		[Ordinal(16)] 
		[RED("quadSettings")] 
		public audioQuadEmitterSettings QuadSettings
		{
			get => GetPropertyValue<audioQuadEmitterSettings>();
			set => SetPropertyValue<audioQuadEmitterSettings>(value);
		}

		[Ordinal(17)] 
		[RED("outerDistance")] 
		public CFloat OuterDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("verticalOuterDistance")] 
		public CFloat VerticalOuterDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("insideSourceDistance")] 
		public CFloat InsideSourceDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("eventOverrides")] 
		public CName EventOverrides
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("outdoornessOverride")] 
		public CBool OutdoornessOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("outdoorness")] 
		public CFloat Outdoorness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("mergeRoomsWithinArea")] 
		public CBool MergeRoomsWithinArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("mixingContext")] 
		public CName MixingContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("ambientPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> AmbientPaletteEntries
		{
			get => GetPropertyValue<CArray<audioAmbientPaletteEntry>>();
			set => SetPropertyValue<CArray<audioAmbientPaletteEntry>>(value);
		}

		public audioAmbientAreaSettings()
		{
			EventsOnEnter = new();
			EventsOnExit = new();
			EventsOnActive = new();
			SoundBanks = new();
			Switches = new();
			Parameters = new();
			GroupingSettings = new audioAmbientAreaGroupingSettings { MaxDistance = 100.000000F };
			QuadSettings = new audioQuadEmitterSettings { Offset = new Vector3(), Events = new(4) };
			AmbientPaletteEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
