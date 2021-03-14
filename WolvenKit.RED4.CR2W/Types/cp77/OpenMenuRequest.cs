using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenMenuRequest : redEvent
	{
		private CName _menuName;
		private CHandle<IScriptable> _userData;
		private CBool _jumpBack;
		private MenuData _eventData;
		private CName _submenuName;
		private CBool _isMainMenu;

		[Ordinal(0)] 
		[RED("menuName")] 
		public CName MenuName
		{
			get
			{
				if (_menuName == null)
				{
					_menuName = (CName) CR2WTypeManager.Create("CName", "menuName", cr2w, this);
				}
				return _menuName;
			}
			set
			{
				if (_menuName == value)
				{
					return;
				}
				_menuName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("jumpBack")] 
		public CBool JumpBack
		{
			get
			{
				if (_jumpBack == null)
				{
					_jumpBack = (CBool) CR2WTypeManager.Create("Bool", "jumpBack", cr2w, this);
				}
				return _jumpBack;
			}
			set
			{
				if (_jumpBack == value)
				{
					return;
				}
				_jumpBack = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("eventData")] 
		public MenuData EventData
		{
			get
			{
				if (_eventData == null)
				{
					_eventData = (MenuData) CR2WTypeManager.Create("MenuData", "eventData", cr2w, this);
				}
				return _eventData;
			}
			set
			{
				if (_eventData == value)
				{
					return;
				}
				_eventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("submenuName")] 
		public CName SubmenuName
		{
			get
			{
				if (_submenuName == null)
				{
					_submenuName = (CName) CR2WTypeManager.Create("CName", "submenuName", cr2w, this);
				}
				return _submenuName;
			}
			set
			{
				if (_submenuName == value)
				{
					return;
				}
				_submenuName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isMainMenu")] 
		public CBool IsMainMenu
		{
			get
			{
				if (_isMainMenu == null)
				{
					_isMainMenu = (CBool) CR2WTypeManager.Create("Bool", "isMainMenu", cr2w, this);
				}
				return _isMainMenu;
			}
			set
			{
				if (_isMainMenu == value)
				{
					return;
				}
				_isMainMenu = value;
				PropertySet(this);
			}
		}

		public OpenMenuRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
