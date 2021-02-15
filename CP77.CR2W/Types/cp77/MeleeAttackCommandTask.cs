using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)] [RED("currentCommand")] public wCHandle<AIMeleeAttackCommand> CurrentCommand { get; set; }
		[Ordinal(2)] [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(3)] [RED("commandDuration")] public CFloat CommandDuration { get; set; }

		public MeleeAttackCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
