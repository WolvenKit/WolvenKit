using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIJoinTargetsSquad : AICommand
	{
		[Ordinal(4)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }

		public AIJoinTargetsSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
