using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhaseNodeDefinition : questEmbeddedGraphNodeDefinition
	{
		private CBool _saveLock;
		private raRef<questQuestPhaseResource> _phaseResource;
		private NodeRef _unfreezingTriggerNodeRef;
		private CArray<questQuestPrefabEntry> _phaseInstancePrefabs;
		private CHandle<questGraphDefinition> _phaseGraph;

		[Ordinal(2)] 
		[RED("saveLock")] 
		public CBool SaveLock
		{
			get => GetProperty(ref _saveLock);
			set => SetProperty(ref _saveLock, value);
		}

		[Ordinal(3)] 
		[RED("phaseResource")] 
		public raRef<questQuestPhaseResource> PhaseResource
		{
			get => GetProperty(ref _phaseResource);
			set => SetProperty(ref _phaseResource, value);
		}

		[Ordinal(4)] 
		[RED("unfreezingTriggerNodeRef")] 
		public NodeRef UnfreezingTriggerNodeRef
		{
			get => GetProperty(ref _unfreezingTriggerNodeRef);
			set => SetProperty(ref _unfreezingTriggerNodeRef, value);
		}

		[Ordinal(5)] 
		[RED("phaseInstancePrefabs")] 
		public CArray<questQuestPrefabEntry> PhaseInstancePrefabs
		{
			get => GetProperty(ref _phaseInstancePrefabs);
			set => SetProperty(ref _phaseInstancePrefabs, value);
		}

		[Ordinal(6)] 
		[RED("phaseGraph")] 
		public CHandle<questGraphDefinition> PhaseGraph
		{
			get => GetProperty(ref _phaseGraph);
			set => SetProperty(ref _phaseGraph, value);
		}

		public questPhaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
