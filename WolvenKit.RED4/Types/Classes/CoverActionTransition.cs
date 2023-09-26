using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class CoverActionTransition : LocomotionTransition
	{
		[Ordinal(3)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(4)] 
		[RED("locomotionStateCallbackID")] 
		public CHandle<redCallbackObject> LocomotionStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("lastSlidingTime")] 
		public CFloat LastSlidingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isSliding")] 
		public CBool IsSliding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CoverActionTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
