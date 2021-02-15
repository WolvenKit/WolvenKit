using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterQuaternion : entAnimInputSetter
	{
		[Ordinal(1)] [RED("value")] public Quaternion Value { get; set; }

		public entAnimInputSetterQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
