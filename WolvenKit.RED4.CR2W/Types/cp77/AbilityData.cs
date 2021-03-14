using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbilityData : CVariable
	{
		private CBool _empty;
		private gameItemID _iD;
		private CString _name;
		private CString _iconPath;
		private CString _categoryName;
		private CString _description;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CBool _isEquipped;
		private CHandle<gameItemData> _gameItemData;
		private CInt32 _assignedIndex;

		[Ordinal(0)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "Empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get
			{
				if (_iD == null)
				{
					_iD = (gameItemID) CR2WTypeManager.Create("gameItemID", "ID", cr2w, this);
				}
				return _iD;
			}
			set
			{
				if (_iD == value)
				{
					return;
				}
				_iD = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "Name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get
			{
				if (_iconPath == null)
				{
					_iconPath = (CString) CR2WTypeManager.Create("String", "IconPath", cr2w, this);
				}
				return _iconPath;
			}
			set
			{
				if (_iconPath == value)
				{
					return;
				}
				_iconPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("CategoryName")] 
		public CString CategoryName
		{
			get
			{
				if (_categoryName == null)
				{
					_categoryName = (CString) CR2WTypeManager.Create("String", "CategoryName", cr2w, this);
				}
				return _categoryName;
			}
			set
			{
				if (_categoryName == value)
				{
					return;
				}
				_categoryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "Description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "EquipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get
			{
				if (_isEquipped == null)
				{
					_isEquipped = (CBool) CR2WTypeManager.Create("Bool", "IsEquipped", cr2w, this);
				}
				return _isEquipped;
			}
			set
			{
				if (_isEquipped == value)
				{
					return;
				}
				_isEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("GameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "GameItemData", cr2w, this);
				}
				return _gameItemData;
			}
			set
			{
				if (_gameItemData == value)
				{
					return;
				}
				_gameItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("AssignedIndex")] 
		public CInt32 AssignedIndex
		{
			get
			{
				if (_assignedIndex == null)
				{
					_assignedIndex = (CInt32) CR2WTypeManager.Create("Int32", "AssignedIndex", cr2w, this);
				}
				return _assignedIndex;
			}
			set
			{
				if (_assignedIndex == value)
				{
					return;
				}
				_assignedIndex = value;
				PropertySet(this);
			}
		}

		public AbilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
