using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorLimiterNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CUInt32 _activationLimitPerFrame;
		private CBool _delayChildActivation;
		private CBool _delayChildActivationIfAttaching;

		[Ordinal(1)] 
		[RED("activationLimitPerFrame")] 
		public CUInt32 ActivationLimitPerFrame
		{
			get => GetProperty(ref _activationLimitPerFrame);
			set => SetProperty(ref _activationLimitPerFrame, value);
		}

		[Ordinal(2)] 
		[RED("delayChildActivation")] 
		public CBool DelayChildActivation
		{
			get => GetProperty(ref _delayChildActivation);
			set => SetProperty(ref _delayChildActivation, value);
		}

		[Ordinal(3)] 
		[RED("delayChildActivationIfAttaching")] 
		public CBool DelayChildActivationIfAttaching
		{
			get => GetProperty(ref _delayChildActivationIfAttaching);
			set => SetProperty(ref _delayChildActivationIfAttaching, value);
		}

		public AIbehaviorLimiterNodeDefinition()
		{
			_activationLimitPerFrame = 1;
		}
	}
}
