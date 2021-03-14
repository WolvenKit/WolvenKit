using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCItemToEquip : CVariable
	{
		private gameItemID _itemID;
		private TweakDBID _slotID;
		private TweakDBID _bodySlotID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("bodySlotID")] 
		public TweakDBID BodySlotID
		{
			get
			{
				if (_bodySlotID == null)
				{
					_bodySlotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "bodySlotID", cr2w, this);
				}
				return _bodySlotID;
			}
			set
			{
				if (_bodySlotID == value)
				{
					return;
				}
				_bodySlotID = value;
				PropertySet(this);
			}
		}

		public NPCItemToEquip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
