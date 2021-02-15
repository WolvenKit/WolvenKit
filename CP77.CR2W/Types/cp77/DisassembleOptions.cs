using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisassembleOptions : CVariable
	{
		[Ordinal(0)] [RED("canBeDisassembled")] public CBool CanBeDisassembled { get; set; }

		public DisassembleOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
