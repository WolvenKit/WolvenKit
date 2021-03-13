using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AimAtTargetCommandCleanup : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }

		public AimAtTargetCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
