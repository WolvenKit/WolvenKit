using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEquipParam : CVariable
	{
		private TweakDBID _slotID;
		private gameItemID _itemIDToEquip;
		private CBool _forceFirstEquip;
		private CBool _instant;

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
		[RED("itemIDToEquip")] 
		public gameItemID ItemIDToEquip
		{
			get
			{
				if (_itemIDToEquip == null)
				{
					_itemIDToEquip = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemIDToEquip", cr2w, this);
				}
				return _itemIDToEquip;
			}
			set
			{
				if (_itemIDToEquip == value)
				{
					return;
				}
				_itemIDToEquip = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		public gameEquipParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
