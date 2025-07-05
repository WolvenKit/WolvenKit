using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_HitReaction : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("npcMissEvents")] 
		public CBool NpcMissEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor_HitReaction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
