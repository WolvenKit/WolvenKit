using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArgumentUint64Value : AIArgumentDefinition
	{
		[Ordinal(3)] [RED("type")] public CEnum<AIArgumentType> Type { get; set; }
		[Ordinal(4)] [RED("defaultValue")] public CUInt64 DefaultValue { get; set; }

		public AIArgumentUint64Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
