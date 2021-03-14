using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuData : CVariable
	{
		private CInt32 _identifier;
		private CString _label;
		private CName _icon;
		private CArray<MenuData> _subMenus;
		private CName _eventName;
		private CName _fullscreenName;
		private CHandle<IScriptable> _userData;
		private CBool _disabled;
		private CInt32 _parentIdentifier;
		private CBool _attrFlag;
		private CInt32 _attrText;
		private CBool _perkFlag;
		private CInt32 _perkText;
		private CBool _overrideDefaultUserData;
		private CBool _overrideSubMenuUserData;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CInt32) CR2WTypeManager.Create("Int32", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("label")] 
		public CString Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CName) CR2WTypeManager.Create("CName", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("subMenus")] 
		public CArray<MenuData> SubMenus
		{
			get
			{
				if (_subMenus == null)
				{
					_subMenus = (CArray<MenuData>) CR2WTypeManager.Create("array:MenuData", "subMenus", cr2w, this);
				}
				return _subMenus;
			}
			set
			{
				if (_subMenus == value)
				{
					return;
				}
				_subMenus = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fullscreenName")] 
		public CName FullscreenName
		{
			get
			{
				if (_fullscreenName == null)
				{
					_fullscreenName = (CName) CR2WTypeManager.Create("CName", "fullscreenName", cr2w, this);
				}
				return _fullscreenName;
			}
			set
			{
				if (_fullscreenName == value)
				{
					return;
				}
				_fullscreenName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("disabled")] 
		public CBool Disabled
		{
			get
			{
				if (_disabled == null)
				{
					_disabled = (CBool) CR2WTypeManager.Create("Bool", "disabled", cr2w, this);
				}
				return _disabled;
			}
			set
			{
				if (_disabled == value)
				{
					return;
				}
				_disabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("parentIdentifier")] 
		public CInt32 ParentIdentifier
		{
			get
			{
				if (_parentIdentifier == null)
				{
					_parentIdentifier = (CInt32) CR2WTypeManager.Create("Int32", "parentIdentifier", cr2w, this);
				}
				return _parentIdentifier;
			}
			set
			{
				if (_parentIdentifier == value)
				{
					return;
				}
				_parentIdentifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attrFlag")] 
		public CBool AttrFlag
		{
			get
			{
				if (_attrFlag == null)
				{
					_attrFlag = (CBool) CR2WTypeManager.Create("Bool", "attrFlag", cr2w, this);
				}
				return _attrFlag;
			}
			set
			{
				if (_attrFlag == value)
				{
					return;
				}
				_attrFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("attrText")] 
		public CInt32 AttrText
		{
			get
			{
				if (_attrText == null)
				{
					_attrText = (CInt32) CR2WTypeManager.Create("Int32", "attrText", cr2w, this);
				}
				return _attrText;
			}
			set
			{
				if (_attrText == value)
				{
					return;
				}
				_attrText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("perkFlag")] 
		public CBool PerkFlag
		{
			get
			{
				if (_perkFlag == null)
				{
					_perkFlag = (CBool) CR2WTypeManager.Create("Bool", "perkFlag", cr2w, this);
				}
				return _perkFlag;
			}
			set
			{
				if (_perkFlag == value)
				{
					return;
				}
				_perkFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("perkText")] 
		public CInt32 PerkText
		{
			get
			{
				if (_perkText == null)
				{
					_perkText = (CInt32) CR2WTypeManager.Create("Int32", "perkText", cr2w, this);
				}
				return _perkText;
			}
			set
			{
				if (_perkText == value)
				{
					return;
				}
				_perkText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("overrideDefaultUserData")] 
		public CBool OverrideDefaultUserData
		{
			get
			{
				if (_overrideDefaultUserData == null)
				{
					_overrideDefaultUserData = (CBool) CR2WTypeManager.Create("Bool", "overrideDefaultUserData", cr2w, this);
				}
				return _overrideDefaultUserData;
			}
			set
			{
				if (_overrideDefaultUserData == value)
				{
					return;
				}
				_overrideDefaultUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("overrideSubMenuUserData")] 
		public CBool OverrideSubMenuUserData
		{
			get
			{
				if (_overrideSubMenuUserData == null)
				{
					_overrideSubMenuUserData = (CBool) CR2WTypeManager.Create("Bool", "overrideSubMenuUserData", cr2w, this);
				}
				return _overrideSubMenuUserData;
			}
			set
			{
				if (_overrideSubMenuUserData == value)
				{
					return;
				}
				_overrideSubMenuUserData = value;
				PropertySet(this);
			}
		}

		public MenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
