using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimsetVariableCondition : animIRuntimeCondition
	{
		[Ordinal(0)] [RED("variableToCompare")] public CName VariableToCompare { get; set; }
		[Ordinal(1)] [RED("valueToCompare")] public CFloat ValueToCompare { get; set; }

		public animAnimsetVariableCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
