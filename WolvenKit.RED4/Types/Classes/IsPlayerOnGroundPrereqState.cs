using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsPlayerOnGroundPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isOnGroundListener")] 
		public CHandle<redCallbackObject> IsOnGroundListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public IsPlayerOnGroundPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
