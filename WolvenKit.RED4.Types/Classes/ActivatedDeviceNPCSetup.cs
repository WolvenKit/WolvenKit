using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceNPCSetup : RedBaseClass
	{
		private NodeRef _npcSpawnerNodeRef;
		private CWeakHandle<NPCPuppet> _npcSpawned;

		[Ordinal(0)] 
		[RED("npcSpawnerNodeRef")] 
		public NodeRef NpcSpawnerNodeRef
		{
			get => GetProperty(ref _npcSpawnerNodeRef);
			set => SetProperty(ref _npcSpawnerNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("npcSpawned")] 
		public CWeakHandle<NPCPuppet> NpcSpawned
		{
			get => GetProperty(ref _npcSpawned);
			set => SetProperty(ref _npcSpawned, value);
		}
	}
}
