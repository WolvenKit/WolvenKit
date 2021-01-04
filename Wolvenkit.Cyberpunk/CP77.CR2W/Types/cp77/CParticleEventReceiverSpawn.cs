using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleEventReceiverSpawn : IParticleEvent
	{
		[Ordinal(0)]  [RED("spawnObject")] public CEnum<EParticleEventSpawnObject> SpawnObject { get; set; }

		public CParticleEventReceiverSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
