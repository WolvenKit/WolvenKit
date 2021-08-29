using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		private CHandle<redCallbackObject> _weaponBBID;
		private CEnum<gamePSMMeleeWeapon> _meleeWeaponState;
		private inkWidgetReference _targetColorChange;
		private CHandle<inkanimProxy> _holdAnim;
		private CHandle<inkanimProxy> _aimAnim;

		[Ordinal(18)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetProperty(ref _weaponBBID);
			set => SetProperty(ref _weaponBBID, value);
		}

		[Ordinal(19)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetProperty(ref _meleeWeaponState);
			set => SetProperty(ref _meleeWeaponState, value);
		}

		[Ordinal(20)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(21)] 
		[RED("holdAnim")] 
		public CHandle<inkanimProxy> HoldAnim
		{
			get => GetProperty(ref _holdAnim);
			set => SetProperty(ref _holdAnim, value);
		}

		[Ordinal(22)] 
		[RED("aimAnim")] 
		public CHandle<inkanimProxy> AimAnim
		{
			get => GetProperty(ref _aimAnim);
			set => SetProperty(ref _aimAnim, value);
		}
	}
}
