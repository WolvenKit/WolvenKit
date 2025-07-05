using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorLimiterNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("activationLimitPerFrame")] 
		public CUInt32 ActivationLimitPerFrame
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("delayChildActivation")] 
		public CBool DelayChildActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("delayChildActivationIfAttaching")] 
		public CBool DelayChildActivationIfAttaching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorLimiterNodeDefinition()
		{
			ActivationLimitPerFrame = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
