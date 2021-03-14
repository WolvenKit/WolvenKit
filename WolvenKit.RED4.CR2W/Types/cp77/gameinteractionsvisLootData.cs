using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisLootData : CVariable
	{
		private CBool _isActive;
		private CBool _isListOpen;
		private CBool _e3hack_isWeapon;
		private CInt32 _currentIndex;
		private CString _title;
		private CArray<gameinteractionsvisInteractionChoiceData> _choices;
		private CArray<gameItemID> _itemIDs;
		private entEntityID _ownerId;
		private CBool _isLocked;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isListOpen")] 
		public CBool IsListOpen
		{
			get
			{
				if (_isListOpen == null)
				{
					_isListOpen = (CBool) CR2WTypeManager.Create("Bool", "isListOpen", cr2w, this);
				}
				return _isListOpen;
			}
			set
			{
				if (_isListOpen == value)
				{
					return;
				}
				_isListOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("e3hack_isWeapon")] 
		public CBool E3hack_isWeapon
		{
			get
			{
				if (_e3hack_isWeapon == null)
				{
					_e3hack_isWeapon = (CBool) CR2WTypeManager.Create("Bool", "e3hack_isWeapon", cr2w, this);
				}
				return _e3hack_isWeapon;
			}
			set
			{
				if (_e3hack_isWeapon == value)
				{
					return;
				}
				_e3hack_isWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get
			{
				if (_currentIndex == null)
				{
					_currentIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentIndex", cr2w, this);
				}
				return _currentIndex;
			}
			set
			{
				if (_currentIndex == value)
				{
					return;
				}
				_currentIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisInteractionChoiceData> Choices
		{
			get
			{
				if (_choices == null)
				{
					_choices = (CArray<gameinteractionsvisInteractionChoiceData>) CR2WTypeManager.Create("array:gameinteractionsvisInteractionChoiceData", "choices", cr2w, this);
				}
				return _choices;
			}
			set
			{
				if (_choices == value)
				{
					return;
				}
				_choices = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemIDs")] 
		public CArray<gameItemID> ItemIDs
		{
			get
			{
				if (_itemIDs == null)
				{
					_itemIDs = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "itemIDs", cr2w, this);
				}
				return _itemIDs;
			}
			set
			{
				if (_itemIDs == value)
				{
					return;
				}
				_itemIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get
			{
				if (_ownerId == null)
				{
					_ownerId = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerId", cr2w, this);
				}
				return _ownerId;
			}
			set
			{
				if (_ownerId == value)
				{
					return;
				}
				_ownerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
