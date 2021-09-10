using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwitchSeatsEvents : VehicleEventsTransition
	{
		[Ordinal(3)] 
		[RED("workspotSystem")] 
		public CHandle<gameWorkspotGameSystem> WorkspotSystem
		{
			get => GetPropertyValue<CHandle<gameWorkspotGameSystem>>();
			set => SetPropertyValue<CHandle<gameWorkspotGameSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("enabledSceneMode")] 
		public CBool EnabledSceneMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SwitchSeatsEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;
		}
	}
}
