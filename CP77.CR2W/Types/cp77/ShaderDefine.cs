using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShaderDefine : CVariable
	{
		[Ordinal(0)] [RED("name")] public CString Name { get; set; }
		[Ordinal(1)] [RED("value")] public CString Value { get; set; }

		public ShaderDefine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
