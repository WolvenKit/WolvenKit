using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityTurretReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isShooting")] 
		public CBool IsShooting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SecurityTurretReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
