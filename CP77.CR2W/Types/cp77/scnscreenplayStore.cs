using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStore : CVariable
	{
		[Ordinal(0)] [RED("lines")] public CArray<scnscreenplayDialogLine> Lines { get; set; }
		[Ordinal(1)] [RED("options")] public CArray<scnscreenplayChoiceOption> Options { get; set; }

		public scnscreenplayStore(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
