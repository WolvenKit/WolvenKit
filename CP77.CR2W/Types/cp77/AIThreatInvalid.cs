using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIThreatInvalid : AIAIEvent
	{
		[Ordinal(2)] [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(3)] [RED("threat")] public wCHandle<entEntity> Threat { get; set; }
		[Ordinal(4)] [RED("isEnemy")] public CBool IsEnemy { get; set; }
		[Ordinal(5)] [RED("isHostile")] public CBool IsHostile { get; set; }

		public AIThreatInvalid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
