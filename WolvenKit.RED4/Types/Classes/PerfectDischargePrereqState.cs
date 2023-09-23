using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerfectDischargePrereqState : StatPoolPrereqState
	{
		[Ordinal(4)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("perfectDischargeListener")] 
		public CHandle<PerfectDischargePrereqListener> PerfectDischargeListener
		{
			get => GetPropertyValue<CHandle<PerfectDischargePrereqListener>>();
			set => SetPropertyValue<CHandle<PerfectDischargePrereqListener>>(value);
		}

		public PerfectDischargePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
