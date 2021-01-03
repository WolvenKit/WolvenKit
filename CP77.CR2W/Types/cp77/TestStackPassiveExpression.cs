using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TestStackPassiveExpression : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		[Ordinal(0)]  [RED("SomeNameProperty")] public CName SomeNameProperty { get; set; }

		public TestStackPassiveExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
