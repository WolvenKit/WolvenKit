using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NoAmmoDecisions : WeaponTransition
	{
		[Ordinal(4)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public NoAmmoDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
