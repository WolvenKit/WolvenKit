using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIInjectLookatTargetCommand : AICombatRelatedCommand
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("targetNodeRef")] public NodeRef TargetNodeRef { get; set; }
		[Ordinal(2)]  [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }

		public AIInjectLookatTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
