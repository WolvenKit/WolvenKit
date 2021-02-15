using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefCName : CVariable
	{
		[Ordinal(0)] [RED("variableId")] public CUInt16 VariableId { get; set; }
		[Ordinal(1)] [RED("treeVariable")] public CName TreeVariable { get; set; }
		[Ordinal(2)] [RED("v")] public CName V { get; set; }

		public LibTreeDefCName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
