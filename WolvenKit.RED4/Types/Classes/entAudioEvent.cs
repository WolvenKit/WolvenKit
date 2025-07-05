using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAudioEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("nameData")] 
		public CName NameData
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("floatData")] 
		public CFloat FloatData
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<audioEventActionType> EventType
		{
			get => GetPropertyValue<CEnum<audioEventActionType>>();
			set => SetPropertyValue<CEnum<audioEventActionType>>(value);
		}

		[Ordinal(5)] 
		[RED("eventFlags")] 
		public CEnum<audioAudioEventFlags> EventFlags
		{
			get => GetPropertyValue<CEnum<audioAudioEventFlags>>();
			set => SetPropertyValue<CEnum<audioAudioEventFlags>>(value);
		}

		public entAudioEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
