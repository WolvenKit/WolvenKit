using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioSceneData : audioAudioMetadata
	{
		private CArrayFixedSize<audioAudioStateData> _anyStateArray;
		private CArray<audioAudioStateData> _states;
		private CArray<audioAnyStateTransitionEntry> _anyStateTransitionsTable;
		private CArray<audioVoLineSignal> _voLineSignals;
		private CName _signalLeadingToShutdown;
		private CName _templateScene;
		private CArray<audioAudioSceneStateOverride> _templateSceneStateOverrides;
		private CArray<audioAudioSceneSignalOverride> _templateSceneSignalOverrides;

		[Ordinal(1)] 
		[RED("anyStateArray", 1)] 
		public CArrayFixedSize<audioAudioStateData> AnyStateArray
		{
			get => GetProperty(ref _anyStateArray);
			set => SetProperty(ref _anyStateArray, value);
		}

		[Ordinal(2)] 
		[RED("states")] 
		public CArray<audioAudioStateData> States
		{
			get => GetProperty(ref _states);
			set => SetProperty(ref _states, value);
		}

		[Ordinal(3)] 
		[RED("anyStateTransitionsTable")] 
		public CArray<audioAnyStateTransitionEntry> AnyStateTransitionsTable
		{
			get => GetProperty(ref _anyStateTransitionsTable);
			set => SetProperty(ref _anyStateTransitionsTable, value);
		}

		[Ordinal(4)] 
		[RED("voLineSignals")] 
		public CArray<audioVoLineSignal> VoLineSignals
		{
			get => GetProperty(ref _voLineSignals);
			set => SetProperty(ref _voLineSignals, value);
		}

		[Ordinal(5)] 
		[RED("signalLeadingToShutdown")] 
		public CName SignalLeadingToShutdown
		{
			get => GetProperty(ref _signalLeadingToShutdown);
			set => SetProperty(ref _signalLeadingToShutdown, value);
		}

		[Ordinal(6)] 
		[RED("templateScene")] 
		public CName TemplateScene
		{
			get => GetProperty(ref _templateScene);
			set => SetProperty(ref _templateScene, value);
		}

		[Ordinal(7)] 
		[RED("templateSceneStateOverrides")] 
		public CArray<audioAudioSceneStateOverride> TemplateSceneStateOverrides
		{
			get => GetProperty(ref _templateSceneStateOverrides);
			set => SetProperty(ref _templateSceneStateOverrides, value);
		}

		[Ordinal(8)] 
		[RED("templateSceneSignalOverrides")] 
		public CArray<audioAudioSceneSignalOverride> TemplateSceneSignalOverrides
		{
			get => GetProperty(ref _templateSceneSignalOverrides);
			set => SetProperty(ref _templateSceneSignalOverrides, value);
		}
	}
}
