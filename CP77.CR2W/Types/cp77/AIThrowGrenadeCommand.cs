using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIThrowGrenadeCommand : AICombatRelatedCommand
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("once")] public CBool Once { get; set; }
		[Ordinal(2)]  [RED("targetOverrideNodeRef")] public NodeRef TargetOverrideNodeRef { get; set; }
		[Ordinal(3)]  [RED("targetOverridePuppetRef")] public gameEntityReference TargetOverridePuppetRef { get; set; }

		public AIThrowGrenadeCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
