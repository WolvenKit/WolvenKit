using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLogUserData : inkGameNotificationData
	{
		private gameItemID _itemID;
		private CBool _itemLogQueueEmpty;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("itemLogQueueEmpty")] 
		public CBool ItemLogQueueEmpty
		{
			get
			{
				if (_itemLogQueueEmpty == null)
				{
					_itemLogQueueEmpty = (CBool) CR2WTypeManager.Create("Bool", "itemLogQueueEmpty", cr2w, this);
				}
				return _itemLogQueueEmpty;
			}
			set
			{
				if (_itemLogQueueEmpty == value)
				{
					return;
				}
				_itemLogQueueEmpty = value;
				PropertySet(this);
			}
		}

		public ItemLogUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
