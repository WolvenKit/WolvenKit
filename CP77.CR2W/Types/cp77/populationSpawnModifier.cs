using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class populationSpawnModifier : populationModifier
	{
		[Ordinal(0)]  [RED("spawnParameter")] public CHandle<gameObjectSpawnParameter> SpawnParameter { get; set; }

		public populationSpawnModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
