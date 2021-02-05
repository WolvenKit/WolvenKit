using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArgumentGlobalNodeIdValue : AIArgumentDefinition
	{
		[Ordinal(0)]  [RED("type")] public CEnum<AIArgumentType> Type { get; set; }
		[Ordinal(1)]  [RED("defaultValue")] public worldGlobalNodeID DefaultValue { get; set; }

		public AIArgumentGlobalNodeIdValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
