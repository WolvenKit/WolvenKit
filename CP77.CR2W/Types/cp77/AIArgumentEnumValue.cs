using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArgumentEnumValue : AIArgumentDefinition
	{
		[Ordinal(3)] [RED("type")] public CEnum<AIArgumentType> Type { get; set; }
		[Ordinal(4)] [RED("enumClass")] public CName EnumClass { get; set; }
		[Ordinal(5)] [RED("defaultValue")] public CInt64 DefaultValue { get; set; }

		public AIArgumentEnumValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
