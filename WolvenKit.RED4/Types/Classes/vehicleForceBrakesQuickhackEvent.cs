using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleForceBrakesQuickhackEvent : gameActionEvent
	{
		[Ordinal(4)] 
		[RED("alarmDuration")] 
		public CFloat AlarmDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleForceBrakesQuickhackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
