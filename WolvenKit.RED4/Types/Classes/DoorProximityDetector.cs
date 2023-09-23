using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorProximityDetector : ProximityDetector
	{
		[Ordinal(94)] 
		[RED("triggeredAlarmID")] 
		public gameDelayID TriggeredAlarmID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(95)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(96)] 
		[RED("authorizationLevel")] 
		public CEnum<ESecurityAccessLevel> AuthorizationLevel
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		public DoorProximityDetector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
