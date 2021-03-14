using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sharedMenuItem : CVariable
	{
		private CName _id;
		private CString _displayName;
		private CString _tooltip;
		private CArray<sharedMenuItem> _subItems;
		private CBool _isEnabled;
		private CEnum<sharedMenuItemType> _type;
		private CBool _isChecked;
		private CString _checkGroup;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CName) CR2WTypeManager.Create("CName", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CString) CR2WTypeManager.Create("String", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tooltip")] 
		public CString Tooltip
		{
			get
			{
				if (_tooltip == null)
				{
					_tooltip = (CString) CR2WTypeManager.Create("String", "tooltip", cr2w, this);
				}
				return _tooltip;
			}
			set
			{
				if (_tooltip == value)
				{
					return;
				}
				_tooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("subItems")] 
		public CArray<sharedMenuItem> SubItems
		{
			get
			{
				if (_subItems == null)
				{
					_subItems = (CArray<sharedMenuItem>) CR2WTypeManager.Create("array:sharedMenuItem", "subItems", cr2w, this);
				}
				return _subItems;
			}
			set
			{
				if (_subItems == value)
				{
					return;
				}
				_subItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<sharedMenuItemType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<sharedMenuItemType>) CR2WTypeManager.Create("sharedMenuItemType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isChecked")] 
		public CBool IsChecked
		{
			get
			{
				if (_isChecked == null)
				{
					_isChecked = (CBool) CR2WTypeManager.Create("Bool", "isChecked", cr2w, this);
				}
				return _isChecked;
			}
			set
			{
				if (_isChecked == value)
				{
					return;
				}
				_isChecked = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("checkGroup")] 
		public CString CheckGroup
		{
			get
			{
				if (_checkGroup == null)
				{
					_checkGroup = (CString) CR2WTypeManager.Create("String", "checkGroup", cr2w, this);
				}
				return _checkGroup;
			}
			set
			{
				if (_checkGroup == value)
				{
					return;
				}
				_checkGroup = value;
				PropertySet(this);
			}
		}

		public sharedMenuItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
