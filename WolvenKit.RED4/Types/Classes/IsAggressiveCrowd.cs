using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsAggressiveCrowd : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("reactionSystem")] 
		public CHandle<AIReactionSystem> ReactionSystem
		{
			get => GetPropertyValue<CHandle<AIReactionSystem>>();
			set => SetPropertyValue<CHandle<AIReactionSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("npc")] 
		public CWeakHandle<NPCPuppet> Npc
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public IsAggressiveCrowd()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
