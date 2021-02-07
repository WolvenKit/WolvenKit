using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class redStageMessage : CVariable
	{
		[Ordinal(0)]  [RED("parent")] public CUInt32 Parent { get; set; }
		[Ordinal(1)]  [RED("reset")] public CBool Reset { get; set; }
		[Ordinal(2)]  [RED("names")] public CArray<CString> Names { get; set; }
		[Ordinal(3)]  [RED("ids")] public CArray<CUInt32> Ids { get; set; }

		public redStageMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
