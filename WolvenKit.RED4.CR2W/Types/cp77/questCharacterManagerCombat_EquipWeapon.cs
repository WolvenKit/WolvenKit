using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_EquipWeapon : questICharacterManagerCombat_NodeSubType
	{
		private CBool _equip;
		private TweakDBID _weaponID;
		private TweakDBID _slotID;
		private CBool _equipLastWeapon;
		private CBool _forceFirstEquip;
		private CBool _instant;
		private CBool _ignoreStateMachine;

		[Ordinal(0)] 
		[RED("equip")] 
		public CBool Equip
		{
			get
			{
				if (_equip == null)
				{
					_equip = (CBool) CR2WTypeManager.Create("Bool", "equip", cr2w, this);
				}
				return _equip;
			}
			set
			{
				if (_equip == value)
				{
					return;
				}
				_equip = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("equipLastWeapon")] 
		public CBool EquipLastWeapon
		{
			get
			{
				if (_equipLastWeapon == null)
				{
					_equipLastWeapon = (CBool) CR2WTypeManager.Create("Bool", "equipLastWeapon", cr2w, this);
				}
				return _equipLastWeapon;
			}
			set
			{
				if (_equipLastWeapon == value)
				{
					return;
				}
				_equipLastWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forceFirstEquip")] 
		public CBool ForceFirstEquip
		{
			get
			{
				if (_forceFirstEquip == null)
				{
					_forceFirstEquip = (CBool) CR2WTypeManager.Create("Bool", "forceFirstEquip", cr2w, this);
				}
				return _forceFirstEquip;
			}
			set
			{
				if (_forceFirstEquip == value)
				{
					return;
				}
				_forceFirstEquip = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instant")] 
		public CBool Instant
		{
			get
			{
				if (_instant == null)
				{
					_instant = (CBool) CR2WTypeManager.Create("Bool", "instant", cr2w, this);
				}
				return _instant;
			}
			set
			{
				if (_instant == value)
				{
					return;
				}
				_instant = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ignoreStateMachine")] 
		public CBool IgnoreStateMachine
		{
			get
			{
				if (_ignoreStateMachine == null)
				{
					_ignoreStateMachine = (CBool) CR2WTypeManager.Create("Bool", "ignoreStateMachine", cr2w, this);
				}
				return _ignoreStateMachine;
			}
			set
			{
				if (_ignoreStateMachine == value)
				{
					return;
				}
				_ignoreStateMachine = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_EquipWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
