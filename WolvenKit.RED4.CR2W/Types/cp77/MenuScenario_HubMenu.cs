using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		private CHandle<HubMenuInitData> _hubMenuInitData;
		private wCHandle<inkMenusState> _currentState;

		[Ordinal(4)] 
		[RED("hubMenuInitData")] 
		public CHandle<HubMenuInitData> HubMenuInitData
		{
			get => GetProperty(ref _hubMenuInitData);
			set => SetProperty(ref _hubMenuInitData, value);
		}

		[Ordinal(5)] 
		[RED("currentState")] 
		public wCHandle<inkMenusState> CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		public MenuScenario_HubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
