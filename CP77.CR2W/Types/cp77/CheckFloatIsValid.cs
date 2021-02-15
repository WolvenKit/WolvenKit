using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckFloatIsValid : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("actionTweakIDMapping")] public CHandle<AIArgumentMapping> ActionTweakIDMapping { get; set; }
		[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }

		public CheckFloatIsValid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
