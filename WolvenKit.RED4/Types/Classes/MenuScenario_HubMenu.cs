using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		[Ordinal(4)] 
		[RED("hubMenuInitData")] 
		public CWeakHandle<HubMenuInitData> HubMenuInitData
		{
			get => GetPropertyValue<CWeakHandle<HubMenuInitData>>();
			set => SetPropertyValue<CWeakHandle<HubMenuInitData>>(value);
		}

		[Ordinal(5)] 
		[RED("currentState")] 
		public CWeakHandle<inkMenusState> CurrentState
		{
			get => GetPropertyValue<CWeakHandle<inkMenusState>>();
			set => SetPropertyValue<CWeakHandle<inkMenusState>>(value);
		}

		[Ordinal(6)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public MenuScenario_HubMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
