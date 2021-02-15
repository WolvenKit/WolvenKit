using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableInt32 : LibTreeDefTreeVariable
	{
		[Ordinal(2)] [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }
		[Ordinal(3)] [RED("defaultValue")] public CInt32 DefaultValue { get; set; }

		public LibTreeDefTreeVariableInt32(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
