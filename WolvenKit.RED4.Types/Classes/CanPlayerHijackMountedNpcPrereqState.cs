using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanPlayerHijackMountedNpcPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("mountingListener")] 
		public CHandle<gameScriptedPrereqMountingListenerWrapper> MountingListener
		{
			get => GetPropertyValue<CHandle<gameScriptedPrereqMountingListenerWrapper>>();
			set => SetPropertyValue<CHandle<gameScriptedPrereqMountingListenerWrapper>>(value);
		}
	}
}
