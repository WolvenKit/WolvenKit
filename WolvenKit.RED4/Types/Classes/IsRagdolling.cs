using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsRagdolling : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<NPCPuppet> Npc
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public IsRagdolling()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
