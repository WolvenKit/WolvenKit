using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotPrereq : gameIScriptablePrereq
	{
		private TweakDBID _slotID;
		private CEnum<EItemSlotCheckType> _slotCheckType;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataItemCategory> _itemCategory;
		private CEnum<gamedataWeaponEvolution> _weaponEvolution;
		private CName _itemTag;
		private CBool _invert;
		private CBool _skipOnApply;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("slotCheckType")] 
		public CEnum<EItemSlotCheckType> SlotCheckType
		{
			get
			{
				if (_slotCheckType == null)
				{
					_slotCheckType = (CEnum<EItemSlotCheckType>) CR2WTypeManager.Create("EItemSlotCheckType", "slotCheckType", cr2w, this);
				}
				return _slotCheckType;
			}
			set
			{
				if (_slotCheckType == value)
				{
					return;
				}
				_slotCheckType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get
			{
				if (_itemCategory == null)
				{
					_itemCategory = (CEnum<gamedataItemCategory>) CR2WTypeManager.Create("gamedataItemCategory", "itemCategory", cr2w, this);
				}
				return _itemCategory;
			}
			set
			{
				if (_itemCategory == value)
				{
					return;
				}
				_itemCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weaponEvolution")] 
		public CEnum<gamedataWeaponEvolution> WeaponEvolution
		{
			get
			{
				if (_weaponEvolution == null)
				{
					_weaponEvolution = (CEnum<gamedataWeaponEvolution>) CR2WTypeManager.Create("gamedataWeaponEvolution", "weaponEvolution", cr2w, this);
				}
				return _weaponEvolution;
			}
			set
			{
				if (_weaponEvolution == value)
				{
					return;
				}
				_weaponEvolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get
			{
				if (_itemTag == null)
				{
					_itemTag = (CName) CR2WTypeManager.Create("CName", "itemTag", cr2w, this);
				}
				return _itemTag;
			}
			set
			{
				if (_itemTag == value)
				{
					return;
				}
				_itemTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get
			{
				if (_skipOnApply == null)
				{
					_skipOnApply = (CBool) CR2WTypeManager.Create("Bool", "skipOnApply", cr2w, this);
				}
				return _skipOnApply;
			}
			set
			{
				if (_skipOnApply == value)
				{
					return;
				}
				_skipOnApply = value;
				PropertySet(this);
			}
		}

		public ItemInSlotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
