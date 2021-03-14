using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotEventsPartAddedToSlotEvent : redEvent
	{
		private gameItemID _itemID;
		private gameItemID _partID;

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
		[RED("partID")] 
		public gameItemID PartID
		{
			get
			{
				if (_partID == null)
				{
					_partID = (gameItemID) CR2WTypeManager.Create("gameItemID", "partID", cr2w, this);
				}
				return _partID;
			}
			set
			{
				if (_partID == value)
				{
					return;
				}
				_partID = value;
				PropertySet(this);
			}
		}

		public gameAttachmentSlotEventsPartAddedToSlotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
