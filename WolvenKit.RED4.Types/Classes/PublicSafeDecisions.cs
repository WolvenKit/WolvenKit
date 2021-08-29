using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PublicSafeDecisions : WeaponReadyListenerTransition
	{
		private CBool _isSprinting;
		private CBool _inKereznikov;
		private CBool _inCombat;
		private CBool _inDangerousZone;
		private CBool _inFocusMode;
		private CBool _isInVehicleCombat;
		private CBool _isInVehTurret;
		private CBool _isAiming;
		private CBool _rangedAttackPressed;

		[Ordinal(24)] 
		[RED("isSprinting")] 
		public CBool IsSprinting
		{
			get => GetProperty(ref _isSprinting);
			set => SetProperty(ref _isSprinting, value);
		}

		[Ordinal(25)] 
		[RED("inKereznikov")] 
		public CBool InKereznikov
		{
			get => GetProperty(ref _inKereznikov);
			set => SetProperty(ref _inKereznikov, value);
		}

		[Ordinal(26)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetProperty(ref _inCombat);
			set => SetProperty(ref _inCombat, value);
		}

		[Ordinal(27)] 
		[RED("inDangerousZone")] 
		public CBool InDangerousZone
		{
			get => GetProperty(ref _inDangerousZone);
			set => SetProperty(ref _inDangerousZone, value);
		}

		[Ordinal(28)] 
		[RED("inFocusMode")] 
		public CBool InFocusMode
		{
			get => GetProperty(ref _inFocusMode);
			set => SetProperty(ref _inFocusMode, value);
		}

		[Ordinal(29)] 
		[RED("isInVehicleCombat")] 
		public CBool IsInVehicleCombat
		{
			get => GetProperty(ref _isInVehicleCombat);
			set => SetProperty(ref _isInVehicleCombat, value);
		}

		[Ordinal(30)] 
		[RED("isInVehTurret")] 
		public CBool IsInVehTurret
		{
			get => GetProperty(ref _isInVehTurret);
			set => SetProperty(ref _isInVehTurret, value);
		}

		[Ordinal(31)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(32)] 
		[RED("rangedAttackPressed")] 
		public CBool RangedAttackPressed
		{
			get => GetProperty(ref _rangedAttackPressed);
			set => SetProperty(ref _rangedAttackPressed, value);
		}
	}
}
