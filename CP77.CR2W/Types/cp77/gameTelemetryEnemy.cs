using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryEnemy : CVariable
	{
		[Ordinal(0)] [RED("characterRecord")] public TweakDBID CharacterRecord { get; set; }
		[Ordinal(1)] [RED("enemyAffiliation")] public CString EnemyAffiliation { get; set; }
		[Ordinal(2)] [RED("enemy")] public wCHandle<gameObject> Enemy { get; set; }
		[Ordinal(3)] [RED("enemyEntityID")] public entEntityID EnemyEntityID { get; set; }
		[Ordinal(4)] [RED("archetype")] public CEnum<gamedataArchetypeType> Archetype { get; set; }
		[Ordinal(5)] [RED("level")] public CInt32 Level { get; set; }

		public gameTelemetryEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
