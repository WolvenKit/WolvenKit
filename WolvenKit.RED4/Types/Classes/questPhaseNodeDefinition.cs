using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPhaseNodeDefinition : questEmbeddedGraphNodeDefinition
	{
		[Ordinal(2)] 
		[RED("saveLock")] 
		public CBool SaveLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("phaseResource")] 
		public CResourceAsyncReference<questQuestPhaseResource> PhaseResource
		{
			get => GetPropertyValue<CResourceAsyncReference<questQuestPhaseResource>>();
			set => SetPropertyValue<CResourceAsyncReference<questQuestPhaseResource>>(value);
		}

		[Ordinal(4)] 
		[RED("unfreezingTriggerNodeRef")] 
		public NodeRef UnfreezingTriggerNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("phaseInstancePrefabs")] 
		public CArray<questQuestPrefabEntry> PhaseInstancePrefabs
		{
			get => GetPropertyValue<CArray<questQuestPrefabEntry>>();
			set => SetPropertyValue<CArray<questQuestPrefabEntry>>(value);
		}

		[Ordinal(6)] 
		[RED("phaseGraph")] 
		public CHandle<questGraphDefinition> PhaseGraph
		{
			get => GetPropertyValue<CHandle<questGraphDefinition>>();
			set => SetPropertyValue<CHandle<questGraphDefinition>>(value);
		}

		public questPhaseNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			PhaseInstancePrefabs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
