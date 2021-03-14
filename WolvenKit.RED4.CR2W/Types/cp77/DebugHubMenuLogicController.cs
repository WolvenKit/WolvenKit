using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugHubMenuLogicController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _selectorWidget;
		private wCHandle<hubSelectorController> _selectorCtrl;
		private CArray<CName> _menusList;
		private CArray<CName> _eventsList;
		private CName _defailtMenuName;

		[Ordinal(1)] 
		[RED("selectorWidget")] 
		public wCHandle<inkWidget> SelectorWidget
		{
			get
			{
				if (_selectorWidget == null)
				{
					_selectorWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "selectorWidget", cr2w, this);
				}
				return _selectorWidget;
			}
			set
			{
				if (_selectorWidget == value)
				{
					return;
				}
				_selectorWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selectorCtrl")] 
		public wCHandle<hubSelectorController> SelectorCtrl
		{
			get
			{
				if (_selectorCtrl == null)
				{
					_selectorCtrl = (wCHandle<hubSelectorController>) CR2WTypeManager.Create("whandle:hubSelectorController", "selectorCtrl", cr2w, this);
				}
				return _selectorCtrl;
			}
			set
			{
				if (_selectorCtrl == value)
				{
					return;
				}
				_selectorCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get
			{
				if (_menusList == null)
				{
					_menusList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "menusList", cr2w, this);
				}
				return _menusList;
			}
			set
			{
				if (_menusList == value)
				{
					return;
				}
				_menusList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get
			{
				if (_eventsList == null)
				{
					_eventsList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventsList", cr2w, this);
				}
				return _eventsList;
			}
			set
			{
				if (_eventsList == value)
				{
					return;
				}
				_eventsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defailtMenuName")] 
		public CName DefailtMenuName
		{
			get
			{
				if (_defailtMenuName == null)
				{
					_defailtMenuName = (CName) CR2WTypeManager.Create("CName", "defailtMenuName", cr2w, this);
				}
				return _defailtMenuName;
			}
			set
			{
				if (_defailtMenuName == value)
				{
					return;
				}
				_defailtMenuName = value;
				PropertySet(this);
			}
		}

		public DebugHubMenuLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
