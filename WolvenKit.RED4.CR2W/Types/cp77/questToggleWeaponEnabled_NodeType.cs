using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleWeaponEnabled_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CBool _playerVehicle;
		private CBool _val;
		private CEnum<questVehicleWeaponQuestID> _weapon;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get
			{
				if (_playerVehicle == null)
				{
					_playerVehicle = (CBool) CR2WTypeManager.Create("Bool", "playerVehicle", cr2w, this);
				}
				return _playerVehicle;
			}
			set
			{
				if (_playerVehicle == value)
				{
					return;
				}
				_playerVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("val")] 
		public CBool Val
		{
			get
			{
				if (_val == null)
				{
					_val = (CBool) CR2WTypeManager.Create("Bool", "val", cr2w, this);
				}
				return _val;
			}
			set
			{
				if (_val == value)
				{
					return;
				}
				_val = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public CEnum<questVehicleWeaponQuestID> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (CEnum<questVehicleWeaponQuestID>) CR2WTypeManager.Create("questVehicleWeaponQuestID", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		public questToggleWeaponEnabled_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
