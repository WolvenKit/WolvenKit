using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterFoliageParameters : CMaterialParameter
	{
		[Ordinal(0)]  [RED("foliageProfile")] public rRef<CFoliageProfile> FoliageProfile { get; set; }

		public CMaterialParameterFoliageParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
