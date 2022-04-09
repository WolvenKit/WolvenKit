using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DefaultTransitionStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("transitionOwner")] 
		public CWeakHandle<DefaultTransition> TransitionOwner
		{
			get => GetPropertyValue<CWeakHandle<DefaultTransition>>();
			set => SetPropertyValue<CWeakHandle<DefaultTransition>>(value);
		}

		public DefaultTransitionStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
