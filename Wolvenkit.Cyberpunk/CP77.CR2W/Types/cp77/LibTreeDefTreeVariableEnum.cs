using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableEnum : LibTreeDefTreeVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public CInt64 DefaultValue { get; set; }
		[Ordinal(1)]  [RED("enumClass")] public CName EnumClass { get; set; }
		[Ordinal(2)]  [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
