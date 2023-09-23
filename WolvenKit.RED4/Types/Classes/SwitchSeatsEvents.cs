using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwitchSeatsEvents : VehicleEventsTransition
	{
		[Ordinal(4)] 
		[RED("workspotSystem")] 
		public CHandle<gameWorkspotGameSystem> WorkspotSystem
		{
			get => GetPropertyValue<CHandle<gameWorkspotGameSystem>>();
			set => SetPropertyValue<CHandle<gameWorkspotGameSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("enabledSceneMode")] 
		public CBool EnabledSceneMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SwitchSeatsEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
