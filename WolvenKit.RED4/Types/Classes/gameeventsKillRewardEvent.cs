using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsKillRewardEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("victim")] 
		public CWeakHandle<gameObject> Victim
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetPropertyValue<CEnum<gameKillType>>();
			set => SetPropertyValue<CEnum<gameKillType>>(value);
		}

		public gameeventsKillRewardEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
