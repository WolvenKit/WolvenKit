using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotEventsPartRemovedFromSlotEvent : redEvent
	{
		private gameItemID _itemID;
		private gameItemID _removedPartID;

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
		[RED("removedPartID")] 
		public gameItemID RemovedPartID
		{
			get
			{
				if (_removedPartID == null)
				{
					_removedPartID = (gameItemID) CR2WTypeManager.Create("gameItemID", "removedPartID", cr2w, this);
				}
				return _removedPartID;
			}
			set
			{
				if (_removedPartID == value)
				{
					return;
				}
				_removedPartID = value;
				PropertySet(this);
			}
		}

		public gameAttachmentSlotEventsPartRemovedFromSlotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
