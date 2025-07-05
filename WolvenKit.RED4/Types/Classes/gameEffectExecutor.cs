using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectExecutor : gameEffectNode
	{
		[Ordinal(0)] 
		[RED("usesHitCooldown")] 
		public CBool UsesHitCooldown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
