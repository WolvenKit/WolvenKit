using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIFollowerCommand : AICommand
	{
		[Ordinal(0)]  [RED("combatCommand")] public CBool CombatCommand { get; set; }

		public AIFollowerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
