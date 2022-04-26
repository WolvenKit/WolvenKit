using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneData : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("anyStateArray", 1)] 
		public CArrayFixedSize<audioAudioStateData> AnyStateArray
		{
			get => GetPropertyValue<CArrayFixedSize<audioAudioStateData>>();
			set => SetPropertyValue<CArrayFixedSize<audioAudioStateData>>(value);
		}

		[Ordinal(2)] 
		[RED("states")] 
		public CArray<audioAudioStateData> States
		{
			get => GetPropertyValue<CArray<audioAudioStateData>>();
			set => SetPropertyValue<CArray<audioAudioStateData>>(value);
		}

		[Ordinal(3)] 
		[RED("anyStateTransitionsTable")] 
		public CArray<audioAnyStateTransitionEntry> AnyStateTransitionsTable
		{
			get => GetPropertyValue<CArray<audioAnyStateTransitionEntry>>();
			set => SetPropertyValue<CArray<audioAnyStateTransitionEntry>>(value);
		}

		[Ordinal(4)] 
		[RED("voLineSignals")] 
		public CArray<audioVoLineSignal> VoLineSignals
		{
			get => GetPropertyValue<CArray<audioVoLineSignal>>();
			set => SetPropertyValue<CArray<audioVoLineSignal>>(value);
		}

		[Ordinal(5)] 
		[RED("signalLeadingToShutdown")] 
		public CName SignalLeadingToShutdown
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("templateScene")] 
		public CName TemplateScene
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("templateSceneStateOverrides")] 
		public CArray<audioAudioSceneStateOverride> TemplateSceneStateOverrides
		{
			get => GetPropertyValue<CArray<audioAudioSceneStateOverride>>();
			set => SetPropertyValue<CArray<audioAudioSceneStateOverride>>(value);
		}

		[Ordinal(8)] 
		[RED("templateSceneSignalOverrides")] 
		public CArray<audioAudioSceneSignalOverride> TemplateSceneSignalOverrides
		{
			get => GetPropertyValue<CArray<audioAudioSceneSignalOverride>>();
			set => SetPropertyValue<CArray<audioAudioSceneSignalOverride>>(value);
		}

		public audioAudioSceneData()
		{
			AnyStateArray = new(1);
			States = new();
			AnyStateTransitionsTable = new();
			VoLineSignals = new();
			TemplateSceneStateOverrides = new();
			TemplateSceneSignalOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
