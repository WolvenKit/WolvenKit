using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCAttitudeTowardsPlayerPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("attitudeListener")] 
		public CHandle<gameScriptedPrereqAttitudeListenerWrapper> AttitudeListener
		{
			get => GetPropertyValue<CHandle<gameScriptedPrereqAttitudeListenerWrapper>>();
			set => SetPropertyValue<CHandle<gameScriptedPrereqAttitudeListenerWrapper>>(value);
		}
	}
}
