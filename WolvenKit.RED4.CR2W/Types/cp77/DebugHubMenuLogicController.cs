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
			get => GetProperty(ref _selectorWidget);
			set => SetProperty(ref _selectorWidget, value);
		}

		[Ordinal(2)] 
		[RED("selectorCtrl")] 
		public wCHandle<hubSelectorController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(3)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetProperty(ref _menusList);
			set => SetProperty(ref _menusList, value);
		}

		[Ordinal(4)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get => GetProperty(ref _eventsList);
			set => SetProperty(ref _eventsList, value);
		}

		[Ordinal(5)] 
		[RED("defailtMenuName")] 
		public CName DefailtMenuName
		{
			get => GetProperty(ref _defailtMenuName);
			set => SetProperty(ref _defailtMenuName, value);
		}

		public DebugHubMenuLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
