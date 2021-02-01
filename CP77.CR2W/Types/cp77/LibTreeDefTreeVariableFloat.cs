using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableFloat : LibTreeDefTreeVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(1)]  [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
