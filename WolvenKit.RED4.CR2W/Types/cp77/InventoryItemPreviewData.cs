using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewData : inkGameNotificationData
	{
		private gameItemID _itemID;
		private CString _itemName;
		private CInt32 _requiredLevel;
		private CName _itemQualityState;

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
		[RED("itemName")] 
		public CString ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (CString) CR2WTypeManager.Create("String", "itemName", cr2w, this);
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

		[Ordinal(8)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get
			{
				if (_requiredLevel == null)
				{
					_requiredLevel = (CInt32) CR2WTypeManager.Create("Int32", "requiredLevel", cr2w, this);
				}
				return _requiredLevel;
			}
			set
			{
				if (_requiredLevel == value)
				{
					return;
				}
				_requiredLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemQualityState")] 
		public CName ItemQualityState
		{
			get
			{
				if (_itemQualityState == null)
				{
					_itemQualityState = (CName) CR2WTypeManager.Create("CName", "itemQualityState", cr2w, this);
				}
				return _itemQualityState;
			}
			set
			{
				if (_itemQualityState == value)
				{
					return;
				}
				_itemQualityState = value;
				PropertySet(this);
			}
		}

		public InventoryItemPreviewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
