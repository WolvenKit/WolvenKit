using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerEvent : redEvent
	{
		[Ordinal(0)] [RED("spawnedEntityId")] public entEntityID SpawnedEntityId { get; set; }
		[Ordinal(1)] [RED("eventType")] public CEnum<gameEntitySpawnerEventType> EventType { get; set; }

		public gameEntitySpawnerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
