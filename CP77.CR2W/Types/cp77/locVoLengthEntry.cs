using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class locVoLengthEntry : CVariable
	{
		[Ordinal(0)] [RED("stringId")] public CRUID StringId { get; set; }
		[Ordinal(1)] [RED("femaleLength")] public CFloat FemaleLength { get; set; }
		[Ordinal(2)] [RED("maleLength")] public CFloat MaleLength { get; set; }

		public locVoLengthEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
