using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackCommandHandler : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)] [RED("currentCommand")] public wCHandle<AIMeleeAttackCommand> CurrentCommand { get; set; }

		public MeleeAttackCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
