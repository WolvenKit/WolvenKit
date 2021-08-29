using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwitchSeatsEvents : VehicleEventsTransition
	{
		private CHandle<gameWorkspotGameSystem> _workspotSystem;
		private CBool _enabledSceneMode;

		[Ordinal(3)] 
		[RED("workspotSystem")] 
		public CHandle<gameWorkspotGameSystem> WorkspotSystem
		{
			get => GetProperty(ref _workspotSystem);
			set => SetProperty(ref _workspotSystem, value);
		}

		[Ordinal(4)] 
		[RED("enabledSceneMode")] 
		public CBool EnabledSceneMode
		{
			get => GetProperty(ref _enabledSceneMode);
			set => SetProperty(ref _enabledSceneMode, value);
		}
	}
}
