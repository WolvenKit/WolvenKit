using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerEvent : redEvent
	{
		[Ordinal(0)]  [RED("eventType")] public CEnum<gameEntitySpawnerEventType> EventType { get; set; }
		[Ordinal(1)]  [RED("spawnedEntityId")] public entEntityID SpawnedEntityId { get; set; }

		public gameEntitySpawnerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
