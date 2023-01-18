using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleNoDriveCombatContextDecisions : InputContextTransitionDecisions
	{
		[Ordinal(0)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public VehicleNoDriveCombatContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
