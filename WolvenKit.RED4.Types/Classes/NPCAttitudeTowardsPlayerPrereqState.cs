using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCAttitudeTowardsPlayerPrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqAttitudeListenerWrapper> _attitudeListener;

		[Ordinal(0)] 
		[RED("attitudeListener")] 
		public CHandle<gameScriptedPrereqAttitudeListenerWrapper> AttitudeListener
		{
			get => GetProperty(ref _attitudeListener);
			set => SetProperty(ref _attitudeListener, value);
		}
	}
}
