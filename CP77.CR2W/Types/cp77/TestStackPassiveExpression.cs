using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TestStackPassiveExpression : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("SomeNameProperty")] public CName SomeNameProperty { get; set; }

		public TestStackPassiveExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
