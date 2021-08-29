using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		private CWeakHandle<HubMenuInitData> _hubMenuInitData;
		private CWeakHandle<inkMenusState> _currentState;
		private CUInt32 _hubMenuInstanceID;

		[Ordinal(4)] 
		[RED("hubMenuInitData")] 
		public CWeakHandle<HubMenuInitData> HubMenuInitData
		{
			get => GetProperty(ref _hubMenuInitData);
			set => SetProperty(ref _hubMenuInitData, value);
		}

		[Ordinal(5)] 
		[RED("currentState")] 
		public CWeakHandle<inkMenusState> CurrentState
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
	}
}
