using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotData : CVariable
	{
		private TweakDBID _slotID;
		private CHandle<gameItemObject> _itemObject;
		private gameItemID _activeItemID;
		private gameItemID _prevItemID;

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
		[RED("itemObject")] 
		public CHandle<gameItemObject> ItemObject
		{
			get
			{
				if (_itemObject == null)
				{
					_itemObject = (CHandle<gameItemObject>) CR2WTypeManager.Create("handle:gameItemObject", "itemObject", cr2w, this);
				}
				return _itemObject;
			}
			set
			{
				if (_itemObject == value)
				{
					return;
				}
				_itemObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get
			{
				if (_activeItemID == null)
				{
					_activeItemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "activeItemID", cr2w, this);
				}
				return _activeItemID;
			}
			set
			{
				if (_activeItemID == value)
				{
					return;
				}
				_activeItemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("prevItemID")] 
		public gameItemID PrevItemID
		{
			get
			{
				if (_prevItemID == null)
				{
					_prevItemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "prevItemID", cr2w, this);
				}
				return _prevItemID;
			}
			set
			{
				if (_prevItemID == value)
				{
					return;
				}
				_prevItemID = value;
				PropertySet(this);
			}
		}

		public gameAttachmentSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
