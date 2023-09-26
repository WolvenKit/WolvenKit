using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedForceAboutToExplodeStateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<VehiclePreventionHackState> State
		{
			get => GetPropertyValue<CHandle<VehiclePreventionHackState>>();
			set => SetPropertyValue<CHandle<VehiclePreventionHackState>>(value);
		}

		public DelayedForceAboutToExplodeStateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
