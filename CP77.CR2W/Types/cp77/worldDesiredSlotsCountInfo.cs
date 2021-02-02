using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDesiredSlotsCountInfo : CVariable
	{
		[Ordinal(0)]  [RED("siredSlotsCount")] public CFloat SiredSlotsCount { get; set; }
		[Ordinal(1)]  [RED("nCoeff")] public CFloat NCoeff { get; set; }

		public worldDesiredSlotsCountInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
