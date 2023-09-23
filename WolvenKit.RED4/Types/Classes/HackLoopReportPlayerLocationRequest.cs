using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackLoopReportPlayerLocationRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<VehiclePreventionHackState> State
		{
			get => GetPropertyValue<CHandle<VehiclePreventionHackState>>();
			set => SetPropertyValue<CHandle<VehiclePreventionHackState>>(value);
		}

		public HackLoopReportPlayerLocationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
