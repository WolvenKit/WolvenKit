using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		private wCHandle<HubMenuInitData> _hubMenuInitData;
		private wCHandle<inkMenusState> _currentState;
		private CUInt32 _hubMenuInstanceID;

		[Ordinal(4)] 
		[RED("hubMenuInitData")] 
		public wCHandle<HubMenuInitData> HubMenuInitData
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

		[Ordinal(6)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetProperty(ref _hubMenuInstanceID);
			set => SetProperty(ref _hubMenuInstanceID, value);
		}

		public MenuScenario_HubMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
