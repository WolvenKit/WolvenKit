using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAudioEvent : redEvent
	{
		private CName _eventName;
		private CName _emitterName;
		private CName _nameData;
		private CFloat _floatData;
		private CEnum<audioEventActionType> _eventType;
		private CEnum<audioAudioEventFlags> _eventFlags;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(1)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		[Ordinal(2)] 
		[RED("nameData")] 
		public CName NameData
		{
			get => GetProperty(ref _nameData);
			set => SetProperty(ref _nameData, value);
		}

		[Ordinal(3)] 
		[RED("floatData")] 
		public CFloat FloatData
		{
			get => GetProperty(ref _floatData);
			set => SetProperty(ref _floatData, value);
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<audioEventActionType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		[Ordinal(5)] 
		[RED("eventFlags")] 
		public CEnum<audioAudioEventFlags> EventFlags
		{
			get => GetProperty(ref _eventFlags);
			set => SetProperty(ref _eventFlags, value);
		}
	}
}
