using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAudioSyncs : RedBaseClass
	{
		private CArray<audioAudSwitch> _switchEvents;
		private CArray<audioAudEventStruct> _playEvents;
		private CArray<audioAudEventStruct> _stopEvents;
		private CArray<audioAudParameter> _parameterEvents;

		[Ordinal(0)] 
		[RED("switchEvents")] 
		public CArray<audioAudSwitch> SwitchEvents
		{
			get => GetProperty(ref _switchEvents);
			set => SetProperty(ref _switchEvents, value);
		}

		[Ordinal(1)] 
		[RED("playEvents")] 
		public CArray<audioAudEventStruct> PlayEvents
		{
			get => GetProperty(ref _playEvents);
			set => SetProperty(ref _playEvents, value);
		}

		[Ordinal(2)] 
		[RED("stopEvents")] 
		public CArray<audioAudEventStruct> StopEvents
		{
			get => GetProperty(ref _stopEvents);
			set => SetProperty(ref _stopEvents, value);
		}

		[Ordinal(3)] 
		[RED("parameterEvents")] 
		public CArray<audioAudParameter> ParameterEvents
		{
			get => GetProperty(ref _parameterEvents);
			set => SetProperty(ref _parameterEvents, value);
		}
	}
}
