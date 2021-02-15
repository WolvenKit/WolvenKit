using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckThreat : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("targetObjectMapping")] public CHandle<AIArgumentMapping> TargetObjectMapping { get; set; }
		[Ordinal(1)] [RED("targetThreat")] public wCHandle<gameObject> TargetThreat { get; set; }

		public CheckThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
