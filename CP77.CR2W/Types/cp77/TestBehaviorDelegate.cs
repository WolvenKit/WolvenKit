using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TestBehaviorDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("command")] public CHandle<AICommand> Command { get; set; }
		[Ordinal(1)]  [RED("floatValue")] public CFloat FloatValue { get; set; }
		[Ordinal(2)]  [RED("integer")] public CInt32 Integer { get; set; }
		[Ordinal(3)]  [RED("names")] public CArray<CName> Names { get; set; }
		[Ordinal(4)]  [RED("newProperty")] public CBool NewProperty { get; set; }
		[Ordinal(5)]  [RED("newProperty2")] public CBool NewProperty2 { get; set; }
		[Ordinal(6)]  [RED("newProperty3")] public CBool NewProperty3 { get; set; }
		[Ordinal(7)]  [RED("newProperty4")] public CBool NewProperty4 { get; set; }
		[Ordinal(8)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public TestBehaviorDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
