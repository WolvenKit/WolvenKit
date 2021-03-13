using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatVariable : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("variableName")] public CName VariableName { get; set; }

		public animAnimNode_FloatVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
