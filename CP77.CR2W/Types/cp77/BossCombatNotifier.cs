using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BossCombatNotifier : redEvent
	{
		[Ordinal(0)]  [RED("bossEntity")] public wCHandle<entEntity> BossEntity { get; set; }
		[Ordinal(1)]  [RED("combatEnded")] public CBool CombatEnded { get; set; }

		public BossCombatNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
