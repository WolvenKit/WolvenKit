using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseHubMenuController : gameuiWidgetGameController
	{
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<IScriptable> _menuData;

		[Ordinal(2)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("menuData")] 
		public CHandle<IScriptable> MenuData
		{
			get
			{
				if (_menuData == null)
				{
					_menuData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "menuData", cr2w, this);
				}
				return _menuData;
			}
			set
			{
				if (_menuData == value)
				{
					return;
				}
				_menuData = value;
				PropertySet(this);
			}
		}

		public BaseHubMenuController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
