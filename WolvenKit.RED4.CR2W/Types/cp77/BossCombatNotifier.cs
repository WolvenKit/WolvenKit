using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossCombatNotifier : redEvent
	{
		[Ordinal(0)] [RED("bossEntity")] public wCHandle<entEntity> BossEntity { get; set; }
		[Ordinal(1)] [RED("combatEnded")] public CBool CombatEnded { get; set; }

		public BossCombatNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
