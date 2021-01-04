using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIThreatRemoved : AIAIEvent
	{
		[Ordinal(0)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(1)]  [RED("isEnemy")] public CBool IsEnemy { get; set; }
		[Ordinal(2)]  [RED("isHostile")] public CBool IsHostile { get; set; }
		[Ordinal(3)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(4)]  [RED("threat")] public wCHandle<entEntity> Threat { get; set; }

		public AIThreatRemoved(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
