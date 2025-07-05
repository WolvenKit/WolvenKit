using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceNPCSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("npcSpawnerNodeRef")] 
		public NodeRef NpcSpawnerNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("npcSpawned")] 
		public CWeakHandle<NPCPuppet> NpcSpawned
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public ActivatedDeviceNPCSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
