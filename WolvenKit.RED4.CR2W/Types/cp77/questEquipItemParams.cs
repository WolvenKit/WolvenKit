using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEquipItemParams : questAICommandParams
	{
		private TweakDBID _slotId;
		private CEnum<questNodeType> _type;
		private TweakDBID _itemId;
		private CFloat _equipDurationOverride;
		private CFloat _unequipDurationOverride;
		private CBool _failIfItemNotFound;
		private CBool _instant;
		private CBool _equipLastWeapon;
		private CBool _forceFirstEquip;
		private CBool _ignoreStateMachine;
		private CBool _isPlayer;
		private CEnum<gameItemEquipContexts> _equipTypes;
		private CEnum<gameItemUnequipContexts> _unequipTypes;
		private CBool _byItem;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<questNodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questNodeType>) CR2WTypeManager.Create("questNodeType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("equipDurationOverride")] 
		public CFloat EquipDurationOverride
		{
			get
			{
				if (_equipDurationOverride == null)
				{
					_equipDurationOverride = (CFloat) CR2WTypeManager.Create("Float", "equipDurationOverride", cr2w, this);
				}
				return _equipDurationOverride;
			}
			set
			{
				if (_equipDurationOverride == value)
				{
					return;
				}
				_equipDurationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get
			{
				if (_unequipDurationOverride == null)
				{
					_unequipDurationOverride = (CFloat) CR2WTypeManager.Create("Float", "unequipDurationOverride", cr2w, this);
				}
				return _unequipDurationOverride;
			}
			set
			{
				if (_unequipDurationOverride == value)
				{
					return;
				}
				_unequipDurationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("failIfItemNotFound")] 
		public CBool FailIfItemNotFound
		{
			get
			{
				if (_failIfItemNotFound == null)
				{
					_failIfItemNotFound = (CBool) CR2WTypeManager.Create("Bool", "failIfItemNotFound", cr2w, this);
				}
				return _failIfItemNotFound;
			}
			set
			{
				if (_failIfItemNotFound == value)
				{
					return;
				}
				_failIfItemNotFound = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("equipTypes")] 
		public CEnum<gameItemEquipContexts> EquipTypes
		{
			get
			{
				if (_equipTypes == null)
				{
					_equipTypes = (CEnum<gameItemEquipContexts>) CR2WTypeManager.Create("gameItemEquipContexts", "equipTypes", cr2w, this);
				}
				return _equipTypes;
			}
			set
			{
				if (_equipTypes == value)
				{
					return;
				}
				_equipTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("unequipTypes")] 
		public CEnum<gameItemUnequipContexts> UnequipTypes
		{
			get
			{
				if (_unequipTypes == null)
				{
					_unequipTypes = (CEnum<gameItemUnequipContexts>) CR2WTypeManager.Create("gameItemUnequipContexts", "unequipTypes", cr2w, this);
				}
				return _unequipTypes;
			}
			set
			{
				if (_unequipTypes == value)
				{
					return;
				}
				_unequipTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("byItem")] 
		public CBool ByItem
		{
			get
			{
				if (_byItem == null)
				{
					_byItem = (CBool) CR2WTypeManager.Create("Bool", "byItem", cr2w, this);
				}
				return _byItem;
			}
			set
			{
				if (_byItem == value)
				{
					return;
				}
				_byItem = value;
				PropertySet(this);
			}
		}

		public questEquipItemParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
