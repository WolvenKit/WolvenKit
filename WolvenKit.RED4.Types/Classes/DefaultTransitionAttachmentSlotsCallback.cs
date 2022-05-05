using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DefaultTransitionAttachmentSlotsCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("transitionOwner")] 
		public CWeakHandle<DefaultTransition> TransitionOwner
		{
			get => GetPropertyValue<CWeakHandle<DefaultTransition>>();
			set => SetPropertyValue<CWeakHandle<DefaultTransition>>(value);
		}

		public DefaultTransitionAttachmentSlotsCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
