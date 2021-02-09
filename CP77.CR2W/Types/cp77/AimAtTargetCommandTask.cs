using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AimAtTargetCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)]  [RED("currentCommand")] public wCHandle<AIAimAtTargetCommand> CurrentCommand { get; set; }
		[Ordinal(2)]  [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(3)]  [RED("commandDuration")] public CFloat CommandDuration { get; set; }
		[Ordinal(4)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(5)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public AimAtTargetCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
