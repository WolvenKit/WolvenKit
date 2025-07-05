using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerfectDischargePrereqListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<PerfectDischargePrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<PerfectDischargePrereqState>>();
			set => SetPropertyValue<CWeakHandle<PerfectDischargePrereqState>>(value);
		}

		public PerfectDischargePrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
