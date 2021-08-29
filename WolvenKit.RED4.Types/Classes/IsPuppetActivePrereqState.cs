using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPuppetActivePrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqPSChangeListenerWrapper> _psListener;

		[Ordinal(0)] 
		[RED("psListener")] 
		public CHandle<gameScriptedPrereqPSChangeListenerWrapper> PsListener
		{
			get => GetProperty(ref _psListener);
			set => SetProperty(ref _psListener, value);
		}
	}
}
