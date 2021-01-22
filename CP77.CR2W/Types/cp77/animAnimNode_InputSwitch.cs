using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_InputSwitch : animAnimNode_BaseSwitch
	{
		[Ordinal(0)]  [RED("selectFloatNode")] public animFloatLink SelectFloatNode { get; set; }
		[Ordinal(1)]  [RED("selectIntNode")] public animIntLink SelectIntNode { get; set; }

		public animAnimNode_InputSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
