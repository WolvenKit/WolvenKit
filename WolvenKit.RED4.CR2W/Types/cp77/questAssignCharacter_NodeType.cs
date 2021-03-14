using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAssignCharacter_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _characterRef;
		private gameEntityReference _vehicleRef;
		private CBool _isPlayer;
		private CBool _assign;
		private CName _slotName;
		private CBool _isInstant;
		private CName _entryAnimName;
		private CName _entrySlotName;

		[Ordinal(0)] 
		[RED("characterRef")] 
		public gameEntityReference CharacterRef
		{
			get
			{
				if (_characterRef == null)
				{
					_characterRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "characterRef", cr2w, this);
				}
				return _characterRef;
			}
			set
			{
				if (_characterRef == value)
				{
					return;
				}
				_characterRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("assign")] 
		public CBool Assign
		{
			get
			{
				if (_assign == null)
				{
					_assign = (CBool) CR2WTypeManager.Create("Bool", "assign", cr2w, this);
				}
				return _assign;
			}
			set
			{
				if (_assign == value)
				{
					return;
				}
				_assign = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CBool) CR2WTypeManager.Create("Bool", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("entryAnimName")] 
		public CName EntryAnimName
		{
			get
			{
				if (_entryAnimName == null)
				{
					_entryAnimName = (CName) CR2WTypeManager.Create("CName", "entryAnimName", cr2w, this);
				}
				return _entryAnimName;
			}
			set
			{
				if (_entryAnimName == value)
				{
					return;
				}
				_entryAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("entrySlotName")] 
		public CName EntrySlotName
		{
			get
			{
				if (_entrySlotName == null)
				{
					_entrySlotName = (CName) CR2WTypeManager.Create("CName", "entrySlotName", cr2w, this);
				}
				return _entrySlotName;
			}
			set
			{
				if (_entrySlotName == value)
				{
					return;
				}
				_entrySlotName = value;
				PropertySet(this);
			}
		}

		public questAssignCharacter_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
