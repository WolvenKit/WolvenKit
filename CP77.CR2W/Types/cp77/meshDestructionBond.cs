using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshDestructionBond : CVariable
	{
		[Ordinal(0)] [RED("bondIndex")] public CUInt16 BondIndex { get; set; }
		[Ordinal(1)] [RED("bondHealth")] public CUInt8 BondHealth { get; set; }

		public meshDestructionBond(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
