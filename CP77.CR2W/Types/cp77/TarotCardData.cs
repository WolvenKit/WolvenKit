using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TarotCardData : CVariable
	{
		[Ordinal(0)]  [RED("desc")] public CString Desc { get; set; }
		[Ordinal(1)]  [RED("empty")] public CBool Empty { get; set; }
		[Ordinal(2)]  [RED("imagePath")] public CName ImagePath { get; set; }
		[Ordinal(3)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(4)]  [RED("label")] public CString Label { get; set; }

		public TarotCardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
