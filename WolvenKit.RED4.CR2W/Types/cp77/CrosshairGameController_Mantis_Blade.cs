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
			get
			{
				if (_weaponLocalBB == null)
				{
					_weaponLocalBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponLocalBB", cr2w, this);
				}
				return _weaponLocalBB;
			}
			set
			{
				if (_weaponLocalBB == value)
				{
					return;
				}
				_weaponLocalBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weaponBBID")] 
		public CUInt32 WeaponBBID
		{
			get
			{
				if (_weaponBBID == null)
				{
					_weaponBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponBBID", cr2w, this);
				}
				return _weaponBBID;
			}
			set
			{
				if (_weaponBBID == value)
				{
					return;
				}
				_weaponBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get
			{
				if (_meleeWeaponState == null)
				{
					_meleeWeaponState = (CEnum<gamePSMMeleeWeapon>) CR2WTypeManager.Create("gamePSMMeleeWeapon", "meleeWeaponState", cr2w, this);
				}
				return _meleeWeaponState;
			}
			set
			{
				if (_meleeWeaponState == value)
				{
					return;
				}
				_meleeWeaponState = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get
			{
				if (_targetColorChange == null)
				{
					_targetColorChange = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetColorChange", cr2w, this);
				}
				return _targetColorChange;
			}
			set
			{
				if (_targetColorChange == value)
				{
					return;
				}
				_targetColorChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("holdAnim")] 
		public CHandle<inkanimProxy> HoldAnim
		{
			get
			{
				if (_holdAnim == null)
				{
					_holdAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "holdAnim", cr2w, this);
				}
				return _holdAnim;
			}
			set
			{
				if (_holdAnim == value)
				{
					return;
				}
				_holdAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("aimAnim")] 
		public CHandle<inkanimProxy> AimAnim
		{
			get
			{
				if (_aimAnim == null)
				{
					_aimAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "aimAnim", cr2w, this);
				}
				return _aimAnim;
			}
			set
			{
				if (_aimAnim == value)
				{
					return;
				}
				_aimAnim = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Mantis_Blade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
