using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsVoiceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("gruntType")] 
		public CEnum<audioVoGruntType> GruntType
		{
			get => GetPropertyValue<CEnum<audioVoGruntType>>();
			set => SetPropertyValue<CEnum<audioVoGruntType>>(value);
		}

		[Ordinal(2)] 
		[RED("gruntInterruptMode")] 
		public CEnum<audioVoGruntInterruptMode> GruntInterruptMode
		{
			get => GetPropertyValue<CEnum<audioVoGruntInterruptMode>>();
			set => SetPropertyValue<CEnum<audioVoGruntInterruptMode>>(value);
		}

		[Ordinal(3)] 
		[RED("isV")] 
		public CBool IsV
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameaudioeventsVoiceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
