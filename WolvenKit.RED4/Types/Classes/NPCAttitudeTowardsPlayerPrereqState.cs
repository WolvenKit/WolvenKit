using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCAttitudeTowardsPlayerPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("attitudeListener")] 
		public CHandle<gameScriptedPrereqAttitudeListenerWrapper> AttitudeListener
		{
			get => GetPropertyValue<CHandle<gameScriptedPrereqAttitudeListenerWrapper>>();
			set => SetPropertyValue<CHandle<gameScriptedPrereqAttitudeListenerWrapper>>(value);
		}

		public NPCAttitudeTowardsPlayerPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
