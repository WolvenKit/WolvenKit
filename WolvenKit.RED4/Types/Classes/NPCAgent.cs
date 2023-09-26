using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCAgent : AgentBase
	{
		[Ordinal(3)] 
		[RED("unit")] 
		public CWeakHandle<ScriptedPuppet> Unit
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(4)] 
		[RED("hasBeenAttackedByPlayer")] 
		public CBool HasBeenAttackedByPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isQuestNPC")] 
		public CBool IsQuestNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("spawnedAsFallback")] 
		public CBool SpawnedAsFallback
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("markedToBeDespawned")] 
		public CBool MarkedToBeDespawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCAgent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
