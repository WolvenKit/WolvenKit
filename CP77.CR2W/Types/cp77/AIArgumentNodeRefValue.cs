using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArgumentNodeRefValue : AIArgumentDefinition
	{
		[Ordinal(0)]  [RED("type")] public CEnum<AIArgumentType> Type { get; set; }
		[Ordinal(1)]  [RED("defaultValue")] public NodeRef DefaultValue { get; set; }

		public AIArgumentNodeRefValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
