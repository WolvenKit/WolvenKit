using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		private CHandle<gameIBlackboard> _weaponLocalBB;
		private CUInt32 _weaponBBID;
		private CEnum<gamePSMMeleeWeapon> _meleeWeaponState;
		private inkWidgetReference _targetColorChange;
		private CHandle<inkanimProxy> _holdAnim;
		private CHandle<inkanimProxy> _aimAnim;

		[Ordinal(18)] 
		[RED("weaponLocalBB")] 
		public CHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetProperty(ref _weaponLocalBB);
			set => SetProperty(ref _weaponLocalBB, value);
		}

		[Ordinal(19)] 
		[RED("weaponBBID")] 
		public CUInt32 WeaponBBID
		{
			get => GetProperty(ref _weaponBBID);
			set => SetProperty(ref _weaponBBID, value);
		}

		[Ordinal(20)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetProperty(ref _meleeWeaponState);
			set => SetProperty(ref _meleeWeaponState, value);
		}

		[Ordinal(21)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(22)] 
		[RED("holdAnim")] 
		public CHandle<inkanimProxy> HoldAnim
		{
			get => GetProperty(ref _holdAnim);
			set => SetProperty(ref _holdAnim, value);
		}

		[Ordinal(23)] 
		[RED("aimAnim")] 
		public CHandle<inkanimProxy> AimAnim
		{
			get => GetProperty(ref _aimAnim);
			set => SetProperty(ref _aimAnim, value);
		}

		public CrosshairGameController_Mantis_Blade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
