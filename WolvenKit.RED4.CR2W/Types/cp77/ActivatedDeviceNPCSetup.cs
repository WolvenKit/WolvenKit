using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPCSetup : CVariable
	{
		private NodeRef _npcSpawnerNodeRef;
		private wCHandle<NPCPuppet> _npcSpawned;

		[Ordinal(0)] 
		[RED("npcSpawnerNodeRef")] 
		public NodeRef NpcSpawnerNodeRef
		{
			get => GetProperty(ref _npcSpawnerNodeRef);
			set => SetProperty(ref _npcSpawnerNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("npcSpawned")] 
		public wCHandle<NPCPuppet> NpcSpawned
		{
			get => GetProperty(ref _npcSpawned);
			set => SetProperty(ref _npcSpawned, value);
		}

		public ActivatedDeviceNPCSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
