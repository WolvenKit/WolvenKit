using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableCName : LibTreeDefTreeVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public CName DefaultValue { get; set; }
		[Ordinal(1)]  [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }

		public LibTreeDefTreeVariableCName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
