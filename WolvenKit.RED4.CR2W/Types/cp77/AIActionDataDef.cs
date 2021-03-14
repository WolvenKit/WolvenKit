using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Int32 _ownerMeleeAttackBlockedCount;
		private gamebbScriptID_Int32 _ownerMeleeAttackParriedCount;
		private gamebbScriptID_Int32 _ownerMeleeAttackDodgedCount;
		private gamebbScriptID_Float _ownerLastAttackTimeStamp;
		private gamebbScriptID_CName _ownerLastAttackName;
		private gamebbScriptID_Bool _ownerCurrentAnimVariationSet;
		private gamebbScriptID_Int32 _ownerLastAnimVariation;
		private gamebbScriptID_Variant _ownerItemsToEquip;
		private gamebbScriptID_Variant _ownerItemsUnequipped;
		private gamebbScriptID_Variant _ownerItemsForceUnequipped;
		private gamebbScriptID_Variant _ownerLastEquippedItems;
		private gamebbScriptID_Float _ownerLastUnequipTimestamp;
		private gamebbScriptID_Float _ownerEquipItemTime;
		private gamebbScriptID_Float _ownerEquipDuration;
		private gamebbScriptID_Bool _dropItemOnUnequip;
		private gamebbScriptID_Bool _archetypeEffectorsApplied;
		private gamebbScriptID_Float _ownerTimeDilation;
		private gamebbScriptID_Bool _operationHasBeenProcessed;
		private gamebbScriptID_Bool _weaponTrailInitialised;
		private gamebbScriptID_Bool _weaponTrailAborted;
		private gamebbScriptID_Variant _netrunner;
		private gamebbScriptID_Variant _netrunnerProxy;
		private gamebbScriptID_Variant _netrunnerTarget;

		[Ordinal(0)] 
		[RED("ownerMeleeAttackBlockedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackBlockedCount
		{
			get
			{
				if (_ownerMeleeAttackBlockedCount == null)
				{
					_ownerMeleeAttackBlockedCount = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ownerMeleeAttackBlockedCount", cr2w, this);
				}
				return _ownerMeleeAttackBlockedCount;
			}
			set
			{
				if (_ownerMeleeAttackBlockedCount == value)
				{
					return;
				}
				_ownerMeleeAttackBlockedCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ownerMeleeAttackParriedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackParriedCount
		{
			get
			{
				if (_ownerMeleeAttackParriedCount == null)
				{
					_ownerMeleeAttackParriedCount = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ownerMeleeAttackParriedCount", cr2w, this);
				}
				return _ownerMeleeAttackParriedCount;
			}
			set
			{
				if (_ownerMeleeAttackParriedCount == value)
				{
					return;
				}
				_ownerMeleeAttackParriedCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ownerMeleeAttackDodgedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackDodgedCount
		{
			get
			{
				if (_ownerMeleeAttackDodgedCount == null)
				{
					_ownerMeleeAttackDodgedCount = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ownerMeleeAttackDodgedCount", cr2w, this);
				}
				return _ownerMeleeAttackDodgedCount;
			}
			set
			{
				if (_ownerMeleeAttackDodgedCount == value)
				{
					return;
				}
				_ownerMeleeAttackDodgedCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ownerLastAttackTimeStamp")] 
		public gamebbScriptID_Float OwnerLastAttackTimeStamp
		{
			get
			{
				if (_ownerLastAttackTimeStamp == null)
				{
					_ownerLastAttackTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ownerLastAttackTimeStamp", cr2w, this);
				}
				return _ownerLastAttackTimeStamp;
			}
			set
			{
				if (_ownerLastAttackTimeStamp == value)
				{
					return;
				}
				_ownerLastAttackTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ownerLastAttackName")] 
		public gamebbScriptID_CName OwnerLastAttackName
		{
			get
			{
				if (_ownerLastAttackName == null)
				{
					_ownerLastAttackName = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "ownerLastAttackName", cr2w, this);
				}
				return _ownerLastAttackName;
			}
			set
			{
				if (_ownerLastAttackName == value)
				{
					return;
				}
				_ownerLastAttackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ownerCurrentAnimVariationSet")] 
		public gamebbScriptID_Bool OwnerCurrentAnimVariationSet
		{
			get
			{
				if (_ownerCurrentAnimVariationSet == null)
				{
					_ownerCurrentAnimVariationSet = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ownerCurrentAnimVariationSet", cr2w, this);
				}
				return _ownerCurrentAnimVariationSet;
			}
			set
			{
				if (_ownerCurrentAnimVariationSet == value)
				{
					return;
				}
				_ownerCurrentAnimVariationSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ownerLastAnimVariation")] 
		public gamebbScriptID_Int32 OwnerLastAnimVariation
		{
			get
			{
				if (_ownerLastAnimVariation == null)
				{
					_ownerLastAnimVariation = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ownerLastAnimVariation", cr2w, this);
				}
				return _ownerLastAnimVariation;
			}
			set
			{
				if (_ownerLastAnimVariation == value)
				{
					return;
				}
				_ownerLastAnimVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ownerItemsToEquip")] 
		public gamebbScriptID_Variant OwnerItemsToEquip
		{
			get
			{
				if (_ownerItemsToEquip == null)
				{
					_ownerItemsToEquip = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ownerItemsToEquip", cr2w, this);
				}
				return _ownerItemsToEquip;
			}
			set
			{
				if (_ownerItemsToEquip == value)
				{
					return;
				}
				_ownerItemsToEquip = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ownerItemsUnequipped")] 
		public gamebbScriptID_Variant OwnerItemsUnequipped
		{
			get
			{
				if (_ownerItemsUnequipped == null)
				{
					_ownerItemsUnequipped = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ownerItemsUnequipped", cr2w, this);
				}
				return _ownerItemsUnequipped;
			}
			set
			{
				if (_ownerItemsUnequipped == value)
				{
					return;
				}
				_ownerItemsUnequipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ownerItemsForceUnequipped")] 
		public gamebbScriptID_Variant OwnerItemsForceUnequipped
		{
			get
			{
				if (_ownerItemsForceUnequipped == null)
				{
					_ownerItemsForceUnequipped = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ownerItemsForceUnequipped", cr2w, this);
				}
				return _ownerItemsForceUnequipped;
			}
			set
			{
				if (_ownerItemsForceUnequipped == value)
				{
					return;
				}
				_ownerItemsForceUnequipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ownerLastEquippedItems")] 
		public gamebbScriptID_Variant OwnerLastEquippedItems
		{
			get
			{
				if (_ownerLastEquippedItems == null)
				{
					_ownerLastEquippedItems = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ownerLastEquippedItems", cr2w, this);
				}
				return _ownerLastEquippedItems;
			}
			set
			{
				if (_ownerLastEquippedItems == value)
				{
					return;
				}
				_ownerLastEquippedItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ownerLastUnequipTimestamp")] 
		public gamebbScriptID_Float OwnerLastUnequipTimestamp
		{
			get
			{
				if (_ownerLastUnequipTimestamp == null)
				{
					_ownerLastUnequipTimestamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ownerLastUnequipTimestamp", cr2w, this);
				}
				return _ownerLastUnequipTimestamp;
			}
			set
			{
				if (_ownerLastUnequipTimestamp == value)
				{
					return;
				}
				_ownerLastUnequipTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ownerEquipItemTime")] 
		public gamebbScriptID_Float OwnerEquipItemTime
		{
			get
			{
				if (_ownerEquipItemTime == null)
				{
					_ownerEquipItemTime = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ownerEquipItemTime", cr2w, this);
				}
				return _ownerEquipItemTime;
			}
			set
			{
				if (_ownerEquipItemTime == value)
				{
					return;
				}
				_ownerEquipItemTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ownerEquipDuration")] 
		public gamebbScriptID_Float OwnerEquipDuration
		{
			get
			{
				if (_ownerEquipDuration == null)
				{
					_ownerEquipDuration = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ownerEquipDuration", cr2w, this);
				}
				return _ownerEquipDuration;
			}
			set
			{
				if (_ownerEquipDuration == value)
				{
					return;
				}
				_ownerEquipDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("dropItemOnUnequip")] 
		public gamebbScriptID_Bool DropItemOnUnequip
		{
			get
			{
				if (_dropItemOnUnequip == null)
				{
					_dropItemOnUnequip = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "dropItemOnUnequip", cr2w, this);
				}
				return _dropItemOnUnequip;
			}
			set
			{
				if (_dropItemOnUnequip == value)
				{
					return;
				}
				_dropItemOnUnequip = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("archetypeEffectorsApplied")] 
		public gamebbScriptID_Bool ArchetypeEffectorsApplied
		{
			get
			{
				if (_archetypeEffectorsApplied == null)
				{
					_archetypeEffectorsApplied = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "archetypeEffectorsApplied", cr2w, this);
				}
				return _archetypeEffectorsApplied;
			}
			set
			{
				if (_archetypeEffectorsApplied == value)
				{
					return;
				}
				_archetypeEffectorsApplied = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ownerTimeDilation")] 
		public gamebbScriptID_Float OwnerTimeDilation
		{
			get
			{
				if (_ownerTimeDilation == null)
				{
					_ownerTimeDilation = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ownerTimeDilation", cr2w, this);
				}
				return _ownerTimeDilation;
			}
			set
			{
				if (_ownerTimeDilation == value)
				{
					return;
				}
				_ownerTimeDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("operationHasBeenProcessed")] 
		public gamebbScriptID_Bool OperationHasBeenProcessed
		{
			get
			{
				if (_operationHasBeenProcessed == null)
				{
					_operationHasBeenProcessed = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "operationHasBeenProcessed", cr2w, this);
				}
				return _operationHasBeenProcessed;
			}
			set
			{
				if (_operationHasBeenProcessed == value)
				{
					return;
				}
				_operationHasBeenProcessed = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weaponTrailInitialised")] 
		public gamebbScriptID_Bool WeaponTrailInitialised
		{
			get
			{
				if (_weaponTrailInitialised == null)
				{
					_weaponTrailInitialised = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "weaponTrailInitialised", cr2w, this);
				}
				return _weaponTrailInitialised;
			}
			set
			{
				if (_weaponTrailInitialised == value)
				{
					return;
				}
				_weaponTrailInitialised = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weaponTrailAborted")] 
		public gamebbScriptID_Bool WeaponTrailAborted
		{
			get
			{
				if (_weaponTrailAborted == null)
				{
					_weaponTrailAborted = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "weaponTrailAborted", cr2w, this);
				}
				return _weaponTrailAborted;
			}
			set
			{
				if (_weaponTrailAborted == value)
				{
					return;
				}
				_weaponTrailAborted = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("netrunner")] 
		public gamebbScriptID_Variant Netrunner
		{
			get
			{
				if (_netrunner == null)
				{
					_netrunner = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "netrunner", cr2w, this);
				}
				return _netrunner;
			}
			set
			{
				if (_netrunner == value)
				{
					return;
				}
				_netrunner = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("netrunnerProxy")] 
		public gamebbScriptID_Variant NetrunnerProxy
		{
			get
			{
				if (_netrunnerProxy == null)
				{
					_netrunnerProxy = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "netrunnerProxy", cr2w, this);
				}
				return _netrunnerProxy;
			}
			set
			{
				if (_netrunnerProxy == value)
				{
					return;
				}
				_netrunnerProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("netrunnerTarget")] 
		public gamebbScriptID_Variant NetrunnerTarget
		{
			get
			{
				if (_netrunnerTarget == null)
				{
					_netrunnerTarget = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "netrunnerTarget", cr2w, this);
				}
				return _netrunnerTarget;
			}
			set
			{
				if (_netrunnerTarget == value)
				{
					return;
				}
				_netrunnerTarget = value;
				PropertySet(this);
			}
		}

		public AIActionDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
