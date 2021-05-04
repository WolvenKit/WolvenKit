using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorLimiterNodeDefinition : AIbehaviorDecoratorNodeDefinition
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

		public AIbehaviorLimiterNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
