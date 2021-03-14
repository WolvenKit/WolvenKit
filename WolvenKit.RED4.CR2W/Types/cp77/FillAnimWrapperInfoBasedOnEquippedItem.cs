using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FillAnimWrapperInfoBasedOnEquippedItem : redEvent
	{
		private gameItemID _itemID;
		private CName _itemType;
		private CName _itemName;
		private CBool _clearWrapperInfo;

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
		[RED("itemType")] 
		public CName ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CName) CR2WTypeManager.Create("CName", "itemType", cr2w, this);
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

		[Ordinal(2)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (CName) CR2WTypeManager.Create("CName", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("clearWrapperInfo")] 
		public CBool ClearWrapperInfo
		{
			get
			{
				if (_clearWrapperInfo == null)
				{
					_clearWrapperInfo = (CBool) CR2WTypeManager.Create("Bool", "clearWrapperInfo", cr2w, this);
				}
				return _clearWrapperInfo;
			}
			set
			{
				if (_clearWrapperInfo == value)
				{
					return;
				}
				_clearWrapperInfo = value;
				PropertySet(this);
			}
		}

		public FillAnimWrapperInfoBasedOnEquippedItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
