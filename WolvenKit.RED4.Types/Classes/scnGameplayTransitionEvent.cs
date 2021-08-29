using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnGameplayTransitionEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CEnum<scnPuppetVehicleState> _vehState;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("vehState")] 
		public CEnum<scnPuppetVehicleState> VehState
		{
			get => GetProperty(ref _vehState);
			set => SetProperty(ref _vehState, value);
		}
	}
}
