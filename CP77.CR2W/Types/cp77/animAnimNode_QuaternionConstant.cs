using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionConstant : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] [RED("value")] public Quaternion Value { get; set; }

		public animAnimNode_QuaternionConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
