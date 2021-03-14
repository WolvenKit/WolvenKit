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
			get
			{
				if (_canLook == null)
				{
					_canLook = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canLook", cr2w, this);
				}
				return _canLook;
			}
			set
			{
				if (_canLook == value)
				{
					return;
				}
				_canLook = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("canMove")] 
		public gameMuppetAbility CanMove
		{
			get
			{
				if (_canMove == null)
				{
					_canMove = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canMove", cr2w, this);
				}
				return _canMove;
			}
			set
			{
				if (_canMove == value)
				{
					return;
				}
				_canMove = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("canCrouch")] 
		public gameMuppetAbility CanCrouch
		{
			get
			{
				if (_canCrouch == null)
				{
					_canCrouch = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canCrouch", cr2w, this);
				}
				return _canCrouch;
			}
			set
			{
				if (_canCrouch == value)
				{
					return;
				}
				_canCrouch = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("canSprint")] 
		public gameMuppetAbility CanSprint
		{
			get
			{
				if (_canSprint == null)
				{
					_canSprint = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canSprint", cr2w, this);
				}
				return _canSprint;
			}
			set
			{
				if (_canSprint == value)
				{
					return;
				}
				_canSprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("canSwitchWeapon")] 
		public gameMuppetAbility CanSwitchWeapon
		{
			get
			{
				if (_canSwitchWeapon == null)
				{
					_canSwitchWeapon = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canSwitchWeapon", cr2w, this);
				}
				return _canSwitchWeapon;
			}
			set
			{
				if (_canSwitchWeapon == value)
				{
					return;
				}
				_canSwitchWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("canHoldWeapon")] 
		public gameMuppetAbility CanHoldWeapon
		{
			get
			{
				if (_canHoldWeapon == null)
				{
					_canHoldWeapon = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canHoldWeapon", cr2w, this);
				}
				return _canHoldWeapon;
			}
			set
			{
				if (_canHoldWeapon == value)
				{
					return;
				}
				_canHoldWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("canShoot")] 
		public gameMuppetAbility CanShoot
		{
			get
			{
				if (_canShoot == null)
				{
					_canShoot = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canShoot", cr2w, this);
				}
				return _canShoot;
			}
			set
			{
				if (_canShoot == value)
				{
					return;
				}
				_canShoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("canAimDownSight")] 
		public gameMuppetAbility CanAimDownSight
		{
			get
			{
				if (_canAimDownSight == null)
				{
					_canAimDownSight = (gameMuppetAbility) CR2WTypeManager.Create("gameMuppetAbility", "canAimDownSight", cr2w, this);
				}
				return _canAimDownSight;
			}
			set
			{
				if (_canAimDownSight == value)
				{
					return;
				}
				_canAimDownSight = value;
				PropertySet(this);
			}
		}

		public gameMuppetAbilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
