using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestCombatActionAreaNotification : redEvent
	{
		[Ordinal(0)] [RED("revealPlayerSettings")] public RevealPlayerSettings RevealPlayerSettings { get; set; }

		public QuestCombatActionAreaNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
