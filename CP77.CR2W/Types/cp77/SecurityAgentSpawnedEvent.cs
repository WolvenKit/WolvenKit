using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAgentSpawnedEvent : redEvent
	{
		[Ordinal(0)]  [RED("eventType")] public CEnum<gameEntitySpawnerEventType> EventType { get; set; }
		[Ordinal(1)]  [RED("securityAreas")] public CArray<CHandle<SecurityAreaControllerPS>> SecurityAreas { get; set; }
		[Ordinal(2)]  [RED("spawnedAgent")] public DeviceLink SpawnedAgent { get; set; }

		public SecurityAgentSpawnedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
