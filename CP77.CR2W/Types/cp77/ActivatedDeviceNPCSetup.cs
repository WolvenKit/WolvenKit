using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPCSetup : CVariable
	{
		[Ordinal(0)]  [RED("npcSpawned")] public wCHandle<NPCPuppet> NpcSpawned { get; set; }
		[Ordinal(1)]  [RED("npcSpawnerNodeRef")] public NodeRef NpcSpawnerNodeRef { get; set; }

		public ActivatedDeviceNPCSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
