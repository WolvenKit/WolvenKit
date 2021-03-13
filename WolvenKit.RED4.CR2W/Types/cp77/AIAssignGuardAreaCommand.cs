using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAssignGuardAreaCommand : AICommand
	{
		[Ordinal(4)] [RED("restrictMovementAreaRef")] public NodeRef RestrictMovementAreaRef { get; set; }

		public AIAssignGuardAreaCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
