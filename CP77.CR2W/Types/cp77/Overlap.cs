using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Overlap : CVariable
	{
		[Ordinal(0)] [RED("instructionNumber")] public CInt32 InstructionNumber { get; set; }
		[Ordinal(1)] [RED("otherInstruction")] public CInt32 OtherInstruction { get; set; }
		[Ordinal(2)] [RED("atStart")] public CBool AtStart { get; set; }
		[Ordinal(3)] [RED("rarity")] public CInt32 Rarity { get; set; }

		public Overlap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
