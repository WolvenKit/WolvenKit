using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineFinishedEvent : redEvent
	{
		private gameItemID _itemID;
		private CBool _isFree;
		private CBool _isReady;

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
		[RED("isFree")] 
		public CBool IsFree
		{
			get
			{
				if (_isFree == null)
				{
					_isFree = (CBool) CR2WTypeManager.Create("Bool", "isFree", cr2w, this);
				}
				return _isFree;
			}
			set
			{
				if (_isFree == value)
				{
					return;
				}
				_isFree = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get
			{
				if (_isReady == null)
				{
					_isReady = (CBool) CR2WTypeManager.Create("Bool", "isReady", cr2w, this);
				}
				return _isReady;
			}
			set
			{
				if (_isReady == value)
				{
					return;
				}
				_isReady = value;
				PropertySet(this);
			}
		}

		public VendingMachineFinishedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
