using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DefaultTransitionAttachmentSlotsCallback : gameAttachmentSlotsScriptCallback
	{
		private CWeakHandle<DefaultTransition> _transitionOwner;

		[Ordinal(2)] 
		[RED("transitionOwner")] 
		public CWeakHandle<DefaultTransition> TransitionOwner
		{
			get => GetProperty(ref _transitionOwner);
			set => SetProperty(ref _transitionOwner, value);
		}
	}
}
