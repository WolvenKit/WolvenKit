using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsAttitudeChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("otherAgent")] 
		public CWeakHandle<gameAttitudeAgent> OtherAgent
		{
			get => GetPropertyValue<CWeakHandle<gameAttitudeAgent>>();
			set => SetPropertyValue<CWeakHandle<gameAttitudeAgent>>(value);
		}

		[Ordinal(1)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		public gameeventsAttitudeChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
