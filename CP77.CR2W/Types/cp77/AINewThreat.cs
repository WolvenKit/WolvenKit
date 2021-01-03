using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AINewThreat : AIAIEvent
	{
		[Ordinal(0)]  [RED("isEnemy")] public CBool IsEnemy { get; set; }
		[Ordinal(1)]  [RED("isHostile")] public CBool IsHostile { get; set; }
		[Ordinal(2)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(3)]  [RED("threat")] public wCHandle<entEntity> Threat { get; set; }

		public AINewThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
