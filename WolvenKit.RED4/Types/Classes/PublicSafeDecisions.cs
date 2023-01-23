using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PublicSafeDecisions : WeaponReadyListenerTransition
	{
		[Ordinal(25)] 
		[RED("isSprinting")] 
		public CBool IsSprinting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("inKereznikov")] 
		public CBool InKereznikov
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("inDangerousZone")] 
		public CBool InDangerousZone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("inFocusMode")] 
		public CBool InFocusMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isInVehicleCombat")] 
		public CBool IsInVehicleCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isInVehTurret")] 
		public CBool IsInVehTurret
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("rangedAttackPressed")] 
		public CBool RangedAttackPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PublicSafeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
