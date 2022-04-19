using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsPlayerMovingPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("listenerVertical")] 
		public CHandle<redCallbackObject> ListenerVertical
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public IsPlayerMovingPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
