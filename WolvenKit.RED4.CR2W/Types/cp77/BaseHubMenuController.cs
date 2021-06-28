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
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(3)] 
		[RED("menuData")] 
		public CHandle<IScriptable> MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}

		public BaseHubMenuController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
