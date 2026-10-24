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

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public DefaultTransitionStatListener()
		{
			OwnerID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
