using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterScalar : CMaterialParameter
	{
		[Ordinal(0)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(1)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(2)]  [RED("scalar")] public CFloat Scalar { get; set; }

		public CMaterialParameterScalar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
