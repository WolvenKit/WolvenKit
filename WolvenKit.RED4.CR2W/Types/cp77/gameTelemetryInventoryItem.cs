using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryInventoryItem : CVariable
	{
		private CString _friendlyName;
		private CString _localizedName;
		private gameItemID _itemID;
		private CInt32 _quality;
		private CEnum<gamedataItemType> _itemType;
		private CBool _iconic;
		private CInt32 _itemLevel;
		private CBool _isSilenced;

		[Ordinal(0)] 
		[RED("friendlyName")] 
		public CString FriendlyName
		{
			get
			{
				if (_friendlyName == null)
				{
					_friendlyName = (CString) CR2WTypeManager.Create("String", "friendlyName", cr2w, this);
				}
				return _friendlyName;
			}
			set
			{
				if (_friendlyName == value)
				{
					return;
				}
				_friendlyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CInt32) CR2WTypeManager.Create("Int32", "quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("iconic")] 
		public CBool Iconic
		{
			get
			{
				if (_iconic == null)
				{
					_iconic = (CBool) CR2WTypeManager.Create("Bool", "iconic", cr2w, this);
				}
				return _iconic;
			}
			set
			{
				if (_iconic == value)
				{
					return;
				}
				_iconic = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemLevel")] 
		public CInt32 ItemLevel
		{
			get
			{
				if (_itemLevel == null)
				{
					_itemLevel = (CInt32) CR2WTypeManager.Create("Int32", "itemLevel", cr2w, this);
				}
				return _itemLevel;
			}
			set
			{
				if (_itemLevel == value)
				{
					return;
				}
				_itemLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isSilenced")] 
		public CBool IsSilenced
		{
			get
			{
				if (_isSilenced == null)
				{
					_isSilenced = (CBool) CR2WTypeManager.Create("Bool", "isSilenced", cr2w, this);
				}
				return _isSilenced;
			}
			set
			{
				if (_isSilenced == value)
				{
					return;
				}
				_isSilenced = value;
				PropertySet(this);
			}
		}

		public gameTelemetryInventoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
