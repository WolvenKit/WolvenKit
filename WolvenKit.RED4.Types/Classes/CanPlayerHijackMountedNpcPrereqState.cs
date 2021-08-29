using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanPlayerHijackMountedNpcPrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqMountingListenerWrapper> _mountingListener;

		[Ordinal(0)] 
		[RED("mountingListener")] 
		public CHandle<gameScriptedPrereqMountingListenerWrapper> MountingListener
		{
			get => GetProperty(ref _mountingListener);
			set => SetProperty(ref _mountingListener, value);
		}
	}
}
