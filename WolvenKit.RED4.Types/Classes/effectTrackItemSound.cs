using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemSound : effectTrackItem
	{
		private CName _eventName;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CName _positionName;
		private CName _emitterMetadataName;
		private CName _rtpcName;
		private CHandle<IEvaluatorFloat> _rtpcValue;

		[Ordinal(3)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(4)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetProperty(ref _switches);
			set => SetProperty(ref _switches, value);
		}

		[Ordinal(5)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(6)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetProperty(ref _positionName);
			set => SetProperty(ref _positionName, value);
		}

		[Ordinal(7)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get => GetProperty(ref _emitterMetadataName);
			set => SetProperty(ref _emitterMetadataName, value);
		}

		[Ordinal(8)] 
		[RED("rtpcName")] 
		public CName RtpcName
		{
			get => GetProperty(ref _rtpcName);
			set => SetProperty(ref _rtpcName, value);
		}

		[Ordinal(9)] 
		[RED("rtpcValue")] 
		public CHandle<IEvaluatorFloat> RtpcValue
		{
			get => GetProperty(ref _rtpcValue);
			set => SetProperty(ref _rtpcValue, value);
		}
	}
}
