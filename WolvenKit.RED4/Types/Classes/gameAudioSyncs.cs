using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAudioSyncs : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("switchEvents")] 
		public CArray<audioAudSwitch> SwitchEvents
		{
			get => GetPropertyValue<CArray<audioAudSwitch>>();
			set => SetPropertyValue<CArray<audioAudSwitch>>(value);
		}

		[Ordinal(1)] 
		[RED("playEvents")] 
		public CArray<audioAudEventStruct> PlayEvents
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(2)] 
		[RED("stopEvents")] 
		public CArray<audioAudEventStruct> StopEvents
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(3)] 
		[RED("parameterEvents")] 
		public CArray<audioAudParameter> ParameterEvents
		{
			get => GetPropertyValue<CArray<audioAudParameter>>();
			set => SetPropertyValue<CArray<audioAudParameter>>(value);
		}

		public gameAudioSyncs()
		{
			SwitchEvents = new();
			PlayEvents = new();
			StopEvents = new();
			ParameterEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
