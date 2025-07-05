using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StartHubMenuEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("initData")] 
		public CHandle<HubMenuInitData> InitData
		{
			get => GetPropertyValue<CHandle<HubMenuInitData>>();
			set => SetPropertyValue<CHandle<HubMenuInitData>>(value);
		}

		public StartHubMenuEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
