using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsVehicleDoorLockedState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("psListener")] 
		public CHandle<gameScriptedPrereqPSChangeListenerWrapper> PsListener
		{
			get => GetPropertyValue<CHandle<gameScriptedPrereqPSChangeListenerWrapper>>();
			set => SetPropertyValue<CHandle<gameScriptedPrereqPSChangeListenerWrapper>>(value);
		}

		public IsVehicleDoorLockedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
