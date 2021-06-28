using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetAbilities : CVariable
	{
		private gameMuppetAbility _canLook;
		private gameMuppetAbility _canMove;
		private gameMuppetAbility _canCrouch;
		private gameMuppetAbility _canSprint;
		private gameMuppetAbility _canSwitchWeapon;
		private gameMuppetAbility _canHoldWeapon;
		private gameMuppetAbility _canShoot;
		private gameMuppetAbility _canAimDownSight;

		[Ordinal(0)] 
		[RED("canLook")] 
		public gameMuppetAbility CanLook
		{
			get => GetProperty(ref _canLook);
			set => SetProperty(ref _canLook, value);
		}

		[Ordinal(1)] 
		[RED("canMove")] 
		public gameMuppetAbility CanMove
		{
			get => GetProperty(ref _canMove);
			set => SetProperty(ref _canMove, value);
		}

		[Ordinal(2)] 
		[RED("canCrouch")] 
		public gameMuppetAbility CanCrouch
		{
			get => GetProperty(ref _canCrouch);
			set => SetProperty(ref _canCrouch, value);
		}

		[Ordinal(3)] 
		[RED("canSprint")] 
		public gameMuppetAbility CanSprint
		{
			get => GetProperty(ref _canSprint);
			set => SetProperty(ref _canSprint, value);
		}

		[Ordinal(4)] 
		[RED("canSwitchWeapon")] 
		public gameMuppetAbility CanSwitchWeapon
		{
			get => GetProperty(ref _canSwitchWeapon);
			set => SetProperty(ref _canSwitchWeapon, value);
		}

		[Ordinal(5)] 
		[RED("canHoldWeapon")] 
		public gameMuppetAbility CanHoldWeapon
		{
			get => GetProperty(ref _canHoldWeapon);
			set => SetProperty(ref _canHoldWeapon, value);
		}

		[Ordinal(6)] 
		[RED("canShoot")] 
		public gameMuppetAbility CanShoot
		{
			get => GetProperty(ref _canShoot);
			set => SetProperty(ref _canShoot, value);
		}

		[Ordinal(7)] 
		[RED("canAimDownSight")] 
		public gameMuppetAbility CanAimDownSight
		{
			get => GetProperty(ref _canAimDownSight);
			set => SetProperty(ref _canAimDownSight, value);
		}

		public gameMuppetAbilities(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
