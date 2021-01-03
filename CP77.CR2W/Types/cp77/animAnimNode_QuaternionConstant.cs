using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionConstant : animAnimNode_QuaternionValue
	{
		[Ordinal(0)]  [RED("value")] public Quaternion Value { get; set; }

		public animAnimNode_QuaternionConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
